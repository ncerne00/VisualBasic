Public Class Assignment
    'HOMEWORK REQUIREMENT #1

    Public Property Mechanic As tblMechanic
    Public Property Brand As tblBrand
    Public Property Expertise As Integer
    Public Property Assigned As Boolean
    Public Property ID As String

    Private db As New bit3444_AutoMechanicExpertise
    Public Sub New(ByVal mech As tblMechanic, ByVal brd As tblBrand)
        'creating a unique ID based on a combination of mechanic and brand ID
        Dim uniqueid = mech.mechanicId.ToString + "00" + brd.brandId.ToString
        'pulls the affiliated expertise level associated with a particular mechanic and brand
        Dim expertise = (From expert In db.tblExpertises
                         Where expert.mechanicId = mech.mechanicId And expert.brandId = brd.brandId).Single
        'Sets the objects expertise to the expertise pulled from above
        Me.Expertise = expertise.Expertise
        Brand = brd
        Mechanic = mech
        ID = uniqueid


    End Sub

    'Overrides the ToString function called in frmAssignment, returns s as a string 
    Public Overrides Function ToString() As String
        Dim s As String = Me.Mechanic.FirstName + " " + Me.Mechanic.LastName + " >>> " + Me.Brand.Brand + ": " + Me.Expertise.ToString
        Return s
    End Function
End Class

