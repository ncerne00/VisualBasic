Imports Microsoft.SolverFoundation.Solvers
Imports Microsoft.SolverFoundation.Common
Imports Microsoft.SolverFoundation.Services

Public Class Optimization

    '=========== Simplex Model Helper Functions =================

    Private VarSList As New SortedList(Of String, Integer)
    Private FunSList As New SortedList(Of String, Integer)
    Private myModel As SimplexSolver


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
    End Sub

    ' Add a new function to model
    Private Sub AddFun(funstr As String, lb As Decimal, ub As Decimal)
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
        myModel.AddGoal(FunSList(funstr), 0, isMin)
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

    '=============================================================


    Public Function getOptimalAssignments(ByRef mechanics As List(Of tblMechanic), ByRef brands As List(Of tblBrand), ByRef assignmentOptions As List(Of Assignment)) As Integer

        'HOMEWORK REQUIREMENT #5
        'Complete the getOptimalAssignments function in Optimization.vb
        'Initialize the Solver
        'Add Variables from the assignmentOptions
        'Add Constraints(both Constraint 1 And Constraint 2)
        'Add Objective Function
        'Solve
        'If Optimal Then, the assignment In the list Of assignment Property {Assigned] should be Set To True.
        'Return the Overall Expertise As an Integer

        InitSolver()
        Dim totalExpertise As Integer = 0
        For Each a In assignmentOptions
            AddVar(a.ID, 0, 1)
        Next
        'adding constraints here
        For Each mech In mechanics
            AddFun(mech.mechanicId.ToString + "mech", 1, 1)
        Next
        For Each brd In brands
            AddFun(brd.brandId.ToString + "brd", 1, 1)
        Next
        For Each a In assignmentOptions
            SetCoef(a.Mechanic.mechanicId.ToString + "mech", a.ID, 1)
            SetCoef(a.Brand.brandId.ToString + "brd", a.ID, 1)
        Next
        'setting the objective
        AddObj("obj")
        For Each a In assignmentOptions
            SetCoef("obj", a.ID, a.Expertise)
        Next

        'solving model
        SolveModel("obj", False)
        If IsOptimal() Then
            For Each a In assignmentOptions
                'Go check the variable 0 - if not assigned and 1 if assigned
                If GetVarValue(a.ID) = 1 Then
                    a.Assigned = True
                    totalExpertise = totalExpertise + a.Expertise
                End If
            Next
            Return totalExpertise
        Else
            For Each a In assignmentOptions
                a.Assigned = False
            Next
            Return 0
        End If


    End Function






End Class
