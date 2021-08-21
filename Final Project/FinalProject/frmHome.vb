Public Class frmHome

    'RECOMMENDED VARIABLES TO Use, reference Homework #5
    'I would probably use all these variables if I were doing the project.

    Dim db As New bit3444_projectdata

    'Think about how many assignment options there should be and make sure you loops 
    'correspond to the right number of anticipated options
    Dim assignmentOptions As New List(Of Assignment)

    Dim stafflist As List(Of tblStaff)

    Dim staffnameList As New SortedList(Of Integer, String)
    '^^^^^ HINT ^^^^^^^^: 
    'Add the StaffID and the Display Name in the SortedList
    'Use this list To populate the list box. Then Using a LINQ statement
    'You can get the staffid from the key value to get the Selected Staff 

    Dim projectlist As List(Of tblProject)

    Dim weeks() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}

    'Requirement 1: On Form Load Populate the variables ABOVE ^^^^^^^
    Private Sub frmHome_Load(ByVal sender As Object, e As EventArgs) Handles Me.Load
        stafflist = (From staff In db.tblStaffs
                     Where staff.active).ToList
        projectlist = (From project In db.tblProjects
                       Select project).ToList

        For Each staff In stafflist
            staffnameList.Add(staff.staffid, staff.firstname + " " + staff.lastname)
            For Each proj In projectlist
                assignmentOptions.Add(New Assignment(staff, proj))
            Next
        Next

        For Each proj In projectlist
            projBox.Items.Add(proj.companyName)
        Next

        For Each staff In staffnameList
            staffBox.Items.Add(staff.Value)
        Next


    End Sub



    'Requirement 2: Add a button and check box on the Form and program the OnClick

    Private Sub optimizeBtn_Click(sender As Object, e As EventArgs) Handles optimizeBtn.Click
        Dim result As Decimal
        result = 0.00
        Dim solution As New Optimization
        If realBtn.Checked Then
            result = solution.OptimizeAssignments(stafflist, projectlist, assignmentOptions)
        End If
        If demoBtn.Checked Then
            result = solution.OptimizeAssignmentsDEMO(stafflist, projectlist, assignmentOptions)
        End If
        totalStaffingCostLblOutput.Text = FormatCurrency(result, 2)

        'Requirement 3: Add a Tab Control and various other components
        tabForm.Enabled = True
    End Sub

    Private Sub staffBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles staffBox.SelectedIndexChanged
        'finds specific employee ID from the staffNameList
        hoursTree.Nodes.Clear()
        assignedProjBox.Items.Clear()
        Dim keyfinder = staffBox.SelectedItem
        Dim key As Integer
        Dim sum = 0
        Dim idleHours = 0
        Dim percentIdle = 0
        Dim percentWorking = 0


        For Each employee In staffnameList
            If keyfinder = employee.Value Then
                key = employee.Key
            End If
        Next

        'Gets a specific employee using the key above
        Dim specificStaffMember = (From staff In db.tblStaffs
                                   Where staff.staffid = key).Single

        Dim assignments As List(Of Assignment) = (From a In assignmentOptions
                                                  Where a.Staff.staffid = specificStaffMember.staffid And a.Assigned).ToList
        Dim hours = (From hr In assignments
                     Select hr.TotalHours).FirstOrDefault


        For Each week In weeks
            Dim projHours As Integer = 0

            For Each assignment In assignments
                projHours += (From hr In assignment.WeeklyHours Where hr.weekNum = week Select hr.numberHours).Sum
            Next

            idleHours = 40 - projHours
            hoursTree.Nodes.Add(week.ToString, "Week " + week.ToString + " - " + projHours.ToString + " | " + idleHours.ToString)



        Next

        For Each specificAssignment In assignments
            assignedProjBox.Items.Add(specificAssignment.Project.companyName)
            For Each hr In (From weeklyhours In specificAssignment.WeeklyHours Where weeklyhours.tblProject.projectid = specificAssignment.Project.projectid)
                hoursTree.Nodes.Find(hr.weekNum, True)(0).Nodes.Add(hr.tblProject.companyName + " - " + hr.numberHours.ToString)
            Next
        Next




        nameLbl.Text = "Name: " + staffBox.SelectedItem
        classificationLbl.Text = "Classification: " + (From s In stafflist
                                                       Where staffBox.SelectedItem = s.firstname + " " + s.lastname
                                                       Select s.tblStaffClassification.classification).Single
        baseRateLbl.Text = "Base Rate: $" + (From s In stafflist
                                             Where staffBox.SelectedItem = s.firstname + " " + s.lastname
                                             Select s.base_rate).Single.ToString

        workingHoursLbl.Text = "Working Hours: " + hours.ToString + " (" + Format((hours / (((40 * weeks.Count) - hours) + hours)), "0.00%").ToString + ")"

        idleHoursLbl.Text = "Idle Hours: " + ((40 * weeks.Count) - hours).ToString + " (" + Format((((40 * weeks.Count) - hours) / (((40 * weeks.Count) - hours) + hours)), "0.00%").ToString + ")"

    End Sub

    Private Sub projBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles projBox.SelectedIndexChanged
        assignedStaffBox.Items.Clear()
        Dim key = projBox.SelectedItem
        Dim keyFinder
        For Each proj In projectlist
            If proj.companyName = key Then
                keyFinder = proj.projectid
            End If
        Next
        Dim assignments As List(Of Assignment) = (From a In assignmentOptions
                                                  Where a.Project.projectid = keyFinder And a.Assigned).ToList
        For Each a In assignments

            companyNameLbl.Text = "Company Name: " + a.Project.companyName.ToString
            projRevenueLbl.Text = "Project Revenue: $" + a.Project.projectRevenue.ToString
            industryLbl.Text = "Industry: " + a.Project.industry
            projCostLbl.Text = "Project Cost: $" + a.TotalCost.ToString
            Dim netProfitMargin = 1 - ((a.Project.projectRevenue - a.TotalCost) / a.Project.projectRevenue)
            profitMarginLbl.Text = "Profit Margin: " + Format(netProfitMargin, "0.00%").ToString
            assignedStaffBox.Items.Add(a.Staff.tblStaffClassification.classification + ": " + a.Staff.firstname + " " + a.Staff.lastname)
        Next

    End Sub






    'REMEMBER TO USE LINQ Statements. These statements will get you all the values you need
    'Assignments







End Class