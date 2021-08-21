Public Class Arc
    'Dependencies Node

    'Arc Properties
    Public Property ID As String

    Public Property Tail As Node
    Public Property Head As Node

    Public Property Capacity As Decimal

    Public Property Cost As Decimal

    Public Property Flow As Decimal

    'Constructor
    Public Sub New()

    End Sub

    Public Sub New(t As Node, h As Node)
        Try
            If t Is Nothing Or h Is Nothing Then
                Throw New Exception("Tail or head node does not exist")
            End If
            Tail = t
            Head = h
            ID = Tail.ID & "-TO-" & Head.ID
            Tail.ArcOut.Add(Me)
            Head.ArcIn.Add(Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Arc error")
        End Try

    End Sub

    'Override ToSTring Function

    Public Overrides Function ToString() As String
        Return "Arc: " & ID & ", Capacity: " & Capacity & ", Cost:" & Cost & ", Flow:" & Flow
    End Function

End Class
