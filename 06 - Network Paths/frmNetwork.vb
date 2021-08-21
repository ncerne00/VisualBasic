Public Class frmNetwork

    ' Dependencies: Arc, Map, Network

    ' module scope variables 
    Dim WithEvents myNet As New Network
    Dim myMap As New Map
    Dim radius As Integer = 1000
    Dim nodesAdded As Integer = 0
    Dim arcsAdded As Integer = 0

    ' builds network with respect to a given radius
    Public Sub BuildNetwork()
        myNet.NodeSList.Clear()
        myNet.ArcSList.Clear()
        For Each c In myMap.Cities
            myNet += c
        Next
        For Each c1 In myMap.Cities
            For Each c2 In myMap.Cities
                Dim i1 As Integer = myMap.Cities.IndexOf(c1)
                Dim i2 As Integer = myMap.Cities.IndexOf(c2)
                If i1 <> i2 And myMap.Distance(i1, i2) < radius Then
                    myNet.AddArc(c1, c2)
                    Dim a As Arc = myNet.GetArc(c1, c2)
                    a.Cost = myMap.Distance(i1, i2)
                    a.Capacity = 1
                End If
            Next
        Next

        MessageBox.Show("Network created with " & nodesAdded & " nodes and " & arcsAdded & " arcs.")

    End Sub

    ' handles user-defined NetworkChanged event
    Private Sub myNet_NetworkChanged(net As Network) Handles myNet.NetworkChanged
        nodesAdded = myNet.NodeSList.Count
        arcsAdded = myNet.ArcSList.Count
    End Sub

    ' builds network, finds shortest path and displays in lstPath
    Private Sub btnCreateNetwork_Click(sender As Object, e As EventArgs) Handles btnShortestPath.Click

        Try
            If cboOrigin.SelectedIndex = cboDestination.SelectedIndex Then
                Throw New Exception("Origin and destination cannot be the same city.")
            End If
            radius = CInt(cboRadius.Text)
            BuildNetwork()
            Dim path As List(Of Arc) = myNet.ShortestPath(cboOrigin.Text, cboDestination.Text)
            If path IsNot Nothing Then
                lstPath.Items.Clear()
                Dim totaldist As Integer = 0
                For Each a In path
                    lstPath.Items.Add(a.ToString)
                    totaldist += a.Cost
                Next
                MessageBox.Show("Total distance from " & cboOrigin.Text & " to " &
                                cboDestination.Text & " is " & totaldist & " miles.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Origin/Destination Error")
        End Try
    End Sub

    ' populates origin/destination, radius comboboxes
    Private Sub frmNetwork_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each c In myMap.Cities
            cboOrigin.Items.Add(c)
            cboDestination.Items.Add(c)
        Next
        cboOrigin.SelectedIndex = 0
        cboDestination.SelectedIndex = 0

        For i As Integer = 1 To 15
            cboRadius.Items.Add(i * 100)
        Next
        cboRadius.SelectedIndex = 0
    End Sub

    ' closes form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
