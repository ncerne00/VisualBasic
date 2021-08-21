Public Class Assignment
    'Public PROPERTIES
    Public Property Staff As tblStaff

    Public Property Project As tblProject

    Public Property Rate As Decimal

    Public Property Assigned As Boolean

    Public Property TotalHours As Decimal

    Public Property TotalCost As Decimal
    Public Property ID As String

    Public Property WeeklyHours As List(Of tblProjectHour)

    'VARIABLES
    Dim db As New bit3444_projectdata

    Sub New(ByVal s As tblStaff, ByVal p As tblProject)

        'Assign variables to the properties
        Staff = s
        Project = p


        'Lookup other properties from Database 




        'HINT: Remember that the relates of the tables in the database. You can look at WeeklyHours as an example. 
        'Start my Uncommenting Line 27 & 28 and add in a LINQ statement. You should be able to do it in one line/LINQ

        TotalHours = (From hours In Project.tblProjectHours
                      Where hours.tblStaffClassification.classificationid = Staff.tblStaffClassification.classificationid Select hours.numberHours).Sum

        Rate = (From rate In Staff.tblStaffRates
                Where rate.projectid = Project.projectid
                Select rate.rate).Single



        TotalCost = Rate * TotalHours

        'Assign a list of tblProjectHour for this specific assignment
        'There should be 12 elements in each list
        WeeklyHours = (From hours In Staff.tblStaffClassification.tblProjectHours Where hours.tblProject.projectid = Project.projectid).ToList

        'Assign the ID value to a UNIQUE combiniation
        'ei. S1P1 ... S20P10
        ID = "S" & s.staffid & "P" & p.projectid


        'Default to NOT Assigned
        Assigned = False

    End Sub


End Class
