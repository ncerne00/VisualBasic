Imports Microsoft.SolverFoundation.Solvers
Imports Microsoft.SolverFoundation.Common
Imports Microsoft.SolverFoundation.Services

Public Class Optimization


    Private VarSList As New SortedList(Of String, Integer)
    Private FunSList As New SortedList(Of String, Integer)
    Private myModel As SimplexSolver

    Dim db As New bit3444_projectdata
    Dim local As IQueryable(Of vwWeeklyHoursByStaffProject)

    ' default constructor
    Public Sub New()

    End Sub

    ' Initialization of variable and function lists, and solver
    Private Sub InitSolver()
        VarSList.Clear()
        FunSList.Clear()
        myModel = New SimplexSolver
    End Sub

    ' Add a new variale to model
    Private Sub AddVar(varstr As String, lb As Decimal, ub As Decimal)
        VarSList.Add(varstr, 0)
        myModel.AddVariable(varstr, VarSList(varstr))
        myModel.SetBounds(VarSList(varstr), lb, ub)
        myModel.SetIntegrality(VarSList(varstr), True)
    End Sub

    ' Add a new function to model
    Private Sub AddFun(funstr As String, lb As Integer, ub As Integer)
        FunSList.Add(funstr, 0)
        myModel.AddRow(funstr, FunSList(funstr))
        myModel.SetBounds(FunSList(funstr), lb, ub)
    End Sub

    ' Add an objective function
    Private Sub AddObj(funstr As String)
        FunSList.Add(funstr, 0)
        myModel.AddRow(funstr, FunSList(funstr))
    End Sub


    ' Set coefficient of a variable in a function
    Private Sub SetCoef(funstr As String, varstr As String, coef As Decimal)
        myModel.SetCoefficient(FunSList(funstr), VarSList(varstr), coef)
    End Sub

    ' Solve optimization model
    Private Sub SolveModel(funstr As String, isMin As Boolean)
        myModel.AddGoal(FunSList(funstr), 1, isMin)
        myModel.Solve(New SimplexSolverParams())
    End Sub

    'Get value of variable
    Private Function GetVarValue(varstr As String) As Decimal
        Return myModel.GetValue(VarSList(varstr)).ToDouble
    End Function

    ' Get value of function
    Private Function GetFunValue(funstr As String) As Decimal
        Return myModel.GetValue(FunSList(funstr)).ToDouble
    End Function

    ' Check optimality
    Private Function IsOptimal() As Boolean
        Return myModel.LpResult = 2
    End Function


    Public Function OptimizeAssignmentsDEMO(ByRef stafflist As List(Of tblStaff), ByRef projectlist As List(Of tblProject), ByRef assignmentOptions As List(Of Assignment)) As Decimal
        Dim rand As New Random

        'For DEMO Purposes, assignments will be RANDOM. 
        'This will result in the CONSTRAINTS of the problem Not being met
        For Each assignment In assignmentOptions
            If rand.NextDouble > 0.5 Then
                assignment.Assigned = True
            Else
                assignment.Assigned = False
            End If
        Next


        Return 0


    End Function


    Public Function OptimizeAssignments(ByRef stafflist As List(Of tblStaff), ByRef projectlist As List(Of tblProject), ByRef assignmentOptions As List(Of Assignment)) As Decimal

        Dim weeks() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}

        Dim staffclassifciations As List(Of tblStaffClassification) = (From classifcation In db.tblStaffClassifications).ToList

        InitSolver()

        'Add VARIABLES into the MODEL
        'Variable set one is the Assignment Options
        For Each assignment In assignmentOptions
            AddVar(assignment.ID, 0, 1)
        Next

        'Variable set two is the Idle psudo-variables
        'This Idle represents the total idle time for a Staff Member
        For Each staff In stafflist
            AddVar("Idle" & staff.staffid, 0, 40 * weeks.Length)
        Next

        'Add CONSTRAINTS
        'Contraint one - 40 hours per week
        'Naming S1W1.. S20W12
        For Each staff In stafflist
            For Each week In weeks
                AddFun("S" & staff.staffid & "W" & week, 0, 40)
            Next
        Next

        'Constraint two - One Classifcation Per Project
        'Naming P1C1... P10C4
        For Each project In projectlist
            For Each classifcation In staffclassifciations
                AddFun("P" & project.projectid & "C" & classifcation.classificationid, 1, 1)
            Next
        Next


        'Set COEFFIENTS 
        'Constaint one - Number of Hours Worked

        Dim wkHours As List(Of vwWeeklyHoursByStaffProject) = (From wkhrs In db.vwWeeklyHoursByStaffProjects).ToList

        For Each wkhr In wkHours
            SetCoef("S" & wkhr.staffid & "W" & wkhr.weekNum, "S" & wkhr.staffid & "P" & wkhr.projectid, wkhr.numberHours)
        Next



        'Constaint Idle Hours
        For Each staff In stafflist
            AddFun("S" & staff.staffid & "idle", 40 * weeks.Length, 40 * weeks.Length)
            SetCoef("S" & staff.staffid & "idle", "Idle" & staff.staffid, 1)
        Next

        For Each assignment In assignmentOptions
            'Set Coefficent for One Classication per Project
            SetCoef("P" & assignment.Project.projectid & "C" & assignment.Staff.tblStaffClassification.classificationid, assignment.ID, 1)
            SetCoef("S" & assignment.Staff.staffid & "idle", assignment.ID, assignment.TotalHours)
        Next


        'Add OBJECTIVE
        AddObj("obj")
        For Each assignment In assignmentOptions
            SetCoef("obj", assignment.ID, assignment.TotalCost)
        Next
        For Each staff In stafflist
            SetCoef("obj", "Idle" & staff.staffid, staff.base_rate * 2)
        Next

        'Get the Start Time
        Dim starttime As Date = DateTime.Now

        'Solve the Model
        SolveModel("obj", True)

        'Get the End Time
        Dim endtime As Date = DateTime.Now


        'Message to Show RUN TIME
        Dim work As String = ""

        work += "Solved the Model in " & DateDiff(DateInterval.Second, starttime, endtime) & " seconds" + vbCrLf
        work += "Total Cost: " & GetFunValue("obj").ToString("C") + vbCrLf

        'MessageBox.Show(work)

        If IsOptimal() Then
            For Each assignment In assignmentOptions
                If GetVarValue(assignment.ID) = 1 Then
                    assignment.Assigned = True
                Else
                    assignment.Assigned = False
                End If
            Next

            Return GetFunValue("obj")
        Else
            Return Nothing
        End If



    End Function





End Class
