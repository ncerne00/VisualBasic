Public Class frmEmployeeListing



    Dim employeeList As New List(Of tblStaff)
    Dim employeeNamelist As New SortedList(Of Integer, String)

    Dim db As New bit3444_projectdata

    Private Sub frmEmployeeListing_Load(sender As Object, e As EventArgs) Handles Me.Load

        '1-1 Use a LINQ Statement to fill the employeeList
        employeeList = (From employee In db.tblStaffs
                        Select employee).ToList
        '1-2 Loop through the list and populate the employeeNameList
        For Each employee In employeeList
            employeeNamelist.Add(employee.staffid, employee.firstname + " " + employee.lastname)
        Next
        '1-3 Display the names on the employeeNameList
        For Each employee In employeeNamelist
            employeeBox.Items.Add(employee.Value)
        Next

    End Sub

    Private Sub employeeBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles employeeBox.SelectedIndexChanged

        'Get the specific employeeID from the employeeNameList
        Dim keyFinder = employeeBox.SelectedItem
        Dim key As Integer
        For Each employee In employeeNamelist
            If keyFinder = employee.Value Then
                key = employee.Key
            End If
        Next

        'Get specific employee using th specific employeeID from above ^^^^^
        Dim specificStaffMember = (From staff In db.tblStaffs
                                   Where staff.staffid = key).Single

        'Fill in Employee Data
        idLblOutput.Text = key
        displayLblOutput.Text = specificStaffMember.firstname + " " + specificStaffMember.lastname
        baseRateLblOutput.Text = "$" + specificStaffMember.base_rate.ToString

        'Get the Classification 
        classLblOutput.Text = specificStaffMember.tblStaffClassification.classification

        'Populate List Box, but first clear them out.
        rateBox.Items.Clear()
        Dim max = 0
        Dim highestClient = " "
        Dim staffRates = (From rate In db.tblStaffRates
                          Where rate.staffid = specificStaffMember.staffid)

        For Each r In staffRates
            If r.rate > max Then
                max = r.rate
                highestClient = r.tblProject.companyName
            End If
            rateBox.Items.Add(r.tblProject.companyName + " - $" + r.rate.ToString)
        Next

        clientLblOutput.Text = highestClient

        baseRateLblOutput.Visible = True
        classLblOutput.Visible = True
        clientLblOutput.Visible = True
        displayLblOutput.Visible = True
        idLblOutput.Visible = True
    End Sub


End Class
