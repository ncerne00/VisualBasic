Public Class frmAssignment

    'Use this Entity to Connect to the Database
    Dim db As New bit3444_AutoMechanicExpertise
    Dim mechList As New List(Of tblMechanic)
    Dim brandList As New List(Of tblBrand)
    Dim assignmentList As New List(Of Assignment)

    Private Sub frmAssignment_Load(sender As Object, e As EventArgs) Handles Me.Load
        'HOMEWORK REQUIREMENT #4
        'set values to the class level variables, including the assginmentList. Populate the list boxes of all the mechanics and brands
        specificExpertiseLbl.Visible = False
        brdBox.Enabled = False
        mechBox.Enabled = False
        mechList = (From mech In db.tblMechanics
                    Select mech).ToList
        brandList = (From brd In db.tblBrands
                     Select brd).ToList

        For Each brd In brandList
            brdBox.Items.Add(brd.Brand)
        Next
        For Each mech In mechList
            mechBox.Items.Add(mech.LastName)
        Next

        'Add Loop that create new assignments
        For Each brd In brandList
            For Each mech In mechList
                assignmentList.Add(New Assignment(mech, brd))
            Next
        Next
    End Sub

    Private Sub btnSolve_Click(sender As Object, e As EventArgs) Handles assignmentBtn.Click
        '--------------------------------------------------------- ^^^^^^^^^ Add in the Handles for Your Button

        'HOMEWORK REQUIREMENT #6
        'On the Click event handler for the button, run the optimization code after completing the function 
        'getOptimalAssignments on the class Optimization.  
        'Once the optimization Is run, the list boxes On frmAssignment should be enabled. 
        'Prior To this point, the list boxes should be disabled. 
        'The Total Expertise label should be filled after the optimization has run with the Total Expertise. 
        brdBox.Enabled = True
        mechBox.Enabled = True
        Dim optAssignment As New Optimization
        Dim optSolution = optAssignment.getOptimalAssignments(mechList, brandList, assignmentList)
        expertiseLblOutput.Text = optSolution
    End Sub

    'Checks the mechanic box to see if selected index is changed, updates both the selected item for the brand box and calls the overrides ToString function declared in assignment.
    Private Sub mechBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mechBox.SelectedIndexChanged
        specificExpertiseLbl.Visible = True

        Dim a As Assignment
        a = (From assignment In assignmentList
             Where assignment.Mechanic.LastName = mechBox.SelectedItem
             Where assignment.Assigned).Single

        specificExpertiseLbl.Text = a.ToString

        brdBox.SelectedItem = a.Brand.Brand

    End Sub

    'Checks the brand box to see if selected index is changed, updates both the selected item for the mechanic box and calls the overrides ToString function declared in assignment.
    Private Sub brdBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles brdBox.SelectedIndexChanged
        specificExpertiseLbl.Visible = True


        Dim a As Assignment
        a = (From assignment In assignmentList
             Where assignment.Brand.Brand = brdBox.SelectedItem
             Where assignment.Assigned).Single

        specificExpertiseLbl.Text = a.ToString

        mechBox.SelectedItem = a.Mechanic.LastName

    End Sub
End Class
