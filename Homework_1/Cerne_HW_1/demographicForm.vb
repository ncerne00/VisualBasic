Public Class demographicForm

    ' counting number of entries '
    Dim count As Integer
    Dim maxSubjects As Integer = 10

    ' initializing the 2-D array ' 
    Dim demographicTable(,) As Integer

    Private Function GetAge(age As Integer) As String
        If age < 18 Then
            Return "Junior"
        ElseIf age < 60 Then
            Return "Adult"
        ElseIf age >= 60 Then
            Return "Senior"
        Else
            Return "Uknown age."
        End If
    End Function
    Private Sub demographicForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WireEvents()
    End Sub
    ' exit button event handler ' 
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub
    ' enter button event handler ' 
    Private Sub enterBtn_Click(sender As Object, e As EventArgs) Handles enterBtn.Click
        Dim age As Integer, firstName As String, lastName As String


        If CheckFName() AndAlso
            CheckLName() AndAlso
            CheckAge(age) Then
            If count >= maxSubjects Then
                MessageBox.Show("No more entries allowed. Registry is at it's limit.")
            Else
                age = Integer.Parse(ageBox.Text)
                firstName = fNameBox.Text
                lastName = lNameBox.Text

                count += 1

                outputLabel.Text &= firstName & " " & lastName & ", " & GetAge(age) & vbCrLf
            End If


        End If
    End Sub
    Private Sub WireEvents()
        AddHandler fNameBox.Leave, AddressOf CheckFName
        AddHandler lNameBox.Leave, AddressOf CheckLName
        AddHandler ageBox.Leave, AddressOf CheckAgeNoArg

    End Sub
    Private Function CheckFName() As Boolean
        Try
            If fNameBox.Text = "" Then
                Throw New Exception("Error: no entry for first name.")
            ElseIf IsNumeric(fNameBox.Text) Then
                Throw New Exception("Error: enter a string into first name box.")
            End If
            Return True
        Catch ex As FormatException
            MessageBox.Show("Error in the First Name.", ex.GetType.ToString)
            fNameBox.Focus()
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Input Error")
            fNameBox.Focus()
            Return False
        End Try
    End Function
    Private Function CheckLName() As Boolean
        Try
            If lNameBox.Text = "" Then
                Throw New Exception("Error: no entry for last name.")
            ElseIf IsNumeric(lNameBox.Text) Then
                Throw New Exception("Error: enter a string into last name box.")
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Input Error")
            lNameBox.Focus()
            Return False
        End Try
    End Function
    Private Function CheckAge(ByRef age As Integer) As Boolean
        Try
            age = Integer.Parse(ageBox.Text)
            If ageBox.Text < 0 Then
                Throw New Exception("Age cannot be less than 0.")
            End If
            Return True
        Catch ex As FormatException
            MessageBox.Show("Error in the Age.", ex.GetType.ToString)
            ageBox.Focus()
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Age cannot be less than 0.")
            ageBox.Focus()
            Return False
        End Try
    End Function

    Private Function CheckAgeNoArg() As Boolean
        Dim age As Integer
        Return CheckAge(age)
    End Function


End Class

