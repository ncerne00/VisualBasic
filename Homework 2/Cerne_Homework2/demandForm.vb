Public Class demandFrm

    Dim listProducts As List(Of String)
    Dim listYears As List(Of String)
    Dim sortedList1 As SortedList(Of String, Integer)
    Dim tableArray(,) As Integer

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub

    Private Function GetDemand() As Integer(,)
        Return {{2065, 2230, 2415, 2340},
                   {1630, 1744, 1522, 1434},
                   {4840, 4264, 3096, 4506}}
    End Function
    Private Function GetProducts() As List(Of String)
        Dim productList As New List(Of String)({"ProductA", "ProductB", "ProductC"})
        Return productList


    End Function

    Private Function GetYears() As List(Of String)
        Dim yearsList As New List(Of String)({"2017", "2018", "2019", "2020"})
        Return yearsList
    End Function

    Private Function SrtedList() As SortedList(Of String, Integer)
        Dim srtList As New SortedList(Of String, Integer)

        For i As Integer = 0 To listProducts.Count - 1
            For j As Integer = 0 To listYears.Count - 1
                Dim k = listProducts(i) + " " + listYears(j)
                Dim v = tableArray(i, j)
                srtList.Add(k, v)
            Next
        Next

        Return srtList


    End Function

    Private Sub demandFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tableArray = GetDemand()
        listProducts = GetProducts()
        listYears = GetYears()
        sortedList1 = SrtedList()
    End Sub

    Private Sub showDemandBtn_Click(sender As Object, e As EventArgs) Handles showDemandBtn.Click
        Dim yrprod = productBox.Text + " " + yearBox.Text
        Try
            If Not listYears.Contains(yearBox.Text) Then
                Throw New Exception("Error: year does not exist.")
            End If
            If Not listProducts.Contains(productBox.Text) Then
                Throw New Exception("Error: product does not exist.")
            End If

            MessageBox.Show("In the year " + yearBox.Text + ", " + productBox.Text + " has a demand of " + sortedList1(yrprod).ToString() + ".")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error: check input")
        End Try
    End Sub

    Private Sub showAllDemandBtn_Click(sender As Object, e As EventArgs) Handles showAllDemandBtn.Click
        Dim str As String
        str = " " + vbTab
        For Each yr In listYears
            str += yr + vbTab
        Next
        str += vbNewLine
        For Each prd In listProducts
            str += prd
            str += vbTab
            For Each yr In listYears
                Dim yrprod = prd + " " + yr
                str += sortedList1(yrprod).ToString() + vbTab

            Next
            str += vbNewLine
        Next
        MessageBox.Show(str, "All Demand")
    End Sub
End Class
