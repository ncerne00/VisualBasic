Public Class frmUserInput

    ' counting variables
    Dim count As Integer
    Dim maxCount As Integer = 10
    Dim ja(4)() As String(4)(4)

    ' Array types
    Dim classArray() As Integer
    Dim tableArray(,) As Integer

    ' returns market cap as a string
    Private Function GetMarketCapSize(marketCap As Decimal) As String
        If marketCap < 2 Then
            Return "small-cap"
        ElseIf marketCap < 10 Then
            Return "mid-cap"
        ElseIf marketCap < 200 Then
            Return "large-cap"
        ElseIf marketCap >= 200 Then
            Return "mega-cap"
        Else
            Return "unknown-cap"
        End If
    End Function

    ' returns company class as an integer
    Private Function GetCompanyClass(employees As Integer) As Integer
        Select Case employees
            Case 1 To 9
                Return 1
            Case 10 To 99
                Return 2
            Case 100 To 999
                Return 3
            Case Is >= 1000
                Return 4
            Case Else
                Return 0
        End Select
    End Function

    ' wires events when the form is loaded
    Private Sub frmUserInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WireEvents()
    End Sub

    ' closes form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ' event handler for the Enter button
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim marketCap As Decimal, employees As Integer

        If CheckCompany() AndAlso
           CheckTicker() AndAlso
           CheckMarketCap(marketCap) AndAlso
           CheckEmployees(employees) Then
            If count >= maxCount Then
                MessageBox.Show("No more records allowed.", "Record Limit")
            Else
                classArray = UpdateArray(classArray, GetCompanyClass(employees))
                count = classArray.Length

                tableArray = UpdateTableArray(tableArray, GetCompanyClass(employees), employees)
                count = tableArray.GetLength(1)

                lblDatabase.Text &= txtCompany.Text & " (" & txtTicker.Text & ") is a " &
                    GetMarketCapSize(marketCap) & ", class " &
                    GetCompanyClass(employees) & " company." & vbCrLf

                'ClassCount2()
                'ClassCountAvg()
            End If

        End If
    End Sub

    ' ================================================
    ' Exception handling
    ' ================================================

    ' checks Company input for errors
    Private Function CheckCompany() As Boolean
        Try
            If txtCompany.Text = "" Then
                Throw New Exception("Missing company.")
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Input Error")
            txtCompany.Focus()
            Return False
        End Try
    End Function

    ' checks Ticker Input for errors
    Private Function CheckTicker() As Boolean
        Try
            If txtTicker.Text = "" Then
                Throw New Exception("Missing ticker.")
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            txtTicker.Focus()
            Return False
        End Try
    End Function

    ' Checks MarketCap for errors
    Private Function CheckMarketCap(ByRef marketCap As Decimal) As Boolean
        Try
            'marketCap = CDec(txtMarketCap.Text) ' May throw InvalidCastException
            marketCap = Decimal.Parse(txtMarketCap.Text) ' May throw FormatException
            If marketCap < 0 Then
                Throw New Exception("Market cap cannot be less than zero.")
            End If
            Return True
        Catch ex As FormatException
            MessageBox.Show("Error in market cap.", ex.GetType.ToString)
            txtMarketCap.Focus()
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            txtMarketCap.Focus()
            Return False
        End Try
    End Function

    ' No argument version of CheckMarketCap
    Private Function CheckMarketCapNoArg() As Boolean
        Dim marketCap As Decimal
        Return CheckMarketCap(marketCap)
    End Function

    ' Checks Employees for errors
    Private Function CheckEmployees(ByRef employees As Integer) As Boolean
        Try
            employees = Decimal.Parse(txtEmployees.Text) ' May throw FormatException
            If employees < 1 Then
                Throw New Exception("Employees cannot be less than one.")
            End If
            Return True
        Catch ex As FormatException
            MessageBox.Show("Error in employees.", ex.GetType.ToString)
            txtEmployees.Focus()
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            txtEmployees.Focus()
            Return False
        End Try
    End Function

    ' No argument version of Check Employees
    Private Function CheckEmployeesNoArg() As Boolean
        Dim employees As Integer
        Return CheckEmployees(employees)
    End Function

    ' Wires Leave events to Error checking functions
    Private Sub WireEvents()
        AddHandler txtCompany.Leave, AddressOf CheckCompany
        AddHandler txtTicker.Leave, AddressOf CheckTicker
        AddHandler txtMarketCap.Leave, AddressOf CheckMarketCapNoArg
        AddHandler txtEmployees.Leave, AddressOf CheckEmployeesNoArg
    End Sub


    ' ================================================================
    ' Arrays
    ' ================================================================


    ' IN CLASS  CODE BEGINS HERE %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Function UpdateArray(array() As Integer, companyClass As Integer) As Integer()
        If array Is Nothing Then
            ReDim array(0)
            array(0) = companyClass
        Else
            ReDim Preserve array(array.Length)
            array(array.Length - 1) = companyClass
        End If
        Return array
    End Function


    Private Function UpdateTableArray(array(,) As Integer, companyClass As Integer, employees As Integer) As Integer(,)
        If array Is Nothing Then
            ReDim array(1, 0)
            array(0, 0) = companyClass
            array(1, 0) = employees
        Else
            ReDim Preserve array(array.GetLength(0) - 1, array.GetLength(1))
            array(0, array.GetLength(1) - 1) = companyClass
            array(1, array.GetLength(1) - 1) = employees
        End If
        Return array
    End Function
    ' IN CLASS  CODE ENDS HERE %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    ' ================================================================
    ' Loops
    ' ================================================================

    ' For loop example 1
    Private Sub ClassCount()
        Dim str As String = "Class" & vbTab & "Count" & vbCrLf & vbCrLf

        For i As Integer = 1 To 4
            Dim currCount = 0
            str &= "Class " & i & " : "
            For j As Integer = 0 To maxCount - 1
                If j > classArray.Length - 1 Then
                    Exit For
                ElseIf i = classArray(j) Then
                    currCount += 1
                End If
            Next
            str &= vbTab & currCount & vbCrLf
        Next
        MessageBox.Show(str, "Class Count")
    End Sub


    ' do while loop example 1
    Private Sub ClassCount2()
        Dim str As String = "Class" & vbTab & "Count" & vbCrLf & vbCrLf

        For i As Integer = 1 To 4
            Dim currCount = 0
            str &= "Class " & i & " : "
            Dim j As Integer = 0
            Do While j < maxCount ' Do Until j>= maxCount
                If j > classArray.Length - 1 Then
                    Exit Do
                ElseIf i = classArray(j) Then
                    currCount += 1
                End If
                j += 1
            Loop
            str &= vbTab & currCount & vbCrLf
        Next
        MessageBox.Show(str, "Class Count")
    End Sub

    ' do while loop example 2
    Private Sub ClassCount3()
        Dim str As String = "Class" & vbTab & "Count" & vbCrLf & vbCrLf

        For i As Integer = 1 To 4
            Dim currCount = 0
            str &= "Class " & i & " : "
            Dim j As Integer = 0
            Do
                If j > classArray.Length - 1 Then
                    Exit Do
                ElseIf i = classArray(j) Then
                    currCount += 1
                End If
                j += 1
            Loop While j < maxCount ' Loop Until j>= maxCount
            str &= vbTab & currCount & vbCrLf
        Next
        MessageBox.Show(str, "Class Count")
    End Sub

    ' for each loop example
    Private Sub ClassCount4()
        Dim str As String = "Class" & vbTab & "Count" & vbCrLf & vbCrLf

        For i As Integer = 1 To 4
            Dim currCount = 0
            str &= "Class " & i & " : "
            For Each j In classArray ' j represents the elements of classArray, not the indicies
                If i = j Then
                    currCount += 1
                End If
            Next
            str &= vbTab & currCount & vbCrLf
        Next
        MessageBox.Show(str, "Class Count")
    End Sub

    ' averaging classes
    Private Sub ClassCountAvg()
        Dim str As String = "Class" & vbTab & "Count" & vbTab & "Avg" & vbCrLf & vbCrLf

        For i As Integer = 1 To 4
            Dim currCount = 0
            Dim currSum = 0
            str &= "Class " & i & " : "
            For j As Integer = 0 To tableArray.GetLength(1) - 1
                If i = tableArray(0, j) Then
                    currCount += 1
                    currSum += tableArray(1, j)
                End If
            Next
            Dim currAvg As Decimal = 0
            If currCount > 0 Then
                currAvg = currSum / currCount
            End If
            str &= vbTab & currCount & vbTab & currAvg & vbCrLf
        Next
        MessageBox.Show(str, "Class Count, Avg")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class