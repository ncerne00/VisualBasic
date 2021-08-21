Public Class frmCalculator
    Private Sub btnCalculate_Click(sender As Object,
            e As EventArgs) Handles btnCalculate.Click


        ' HANDS ON EXERCISE CODE STARTS HERE '
        ' PART 1 - ERROR HANDLING

        Try
            Dim operand1 As Decimal = CDec(txtOperand1.Text)
            Dim operator1 As String = txtOperator.Text
            Dim operand2 As Decimal = CDec(txtOperand2.Text)


            If Not IsValidOperator(operator1) Then
                MessageBox.Show("Invalid operator, you must use +, -, *, or /.", "Entry Error")
                txtOperator.SelectAll()
                Exit Sub
            Else
                Dim result As Decimal = CalculationResult(operand1, operator1, operand2)
                result = Math.Round(result, 4)
                txtResult.Text = result.ToString
            End If

        Catch ex As InvalidCastException
            MessageBox.Show("Invalid numeric format. Please check all entries.", "Entry Error")
        Catch ex As OverflowException
            MessageBox.Show("Overflow Error. Please enter smaller values.", "Entry Error")
        Catch ex As DivideByZeroException
            MessageBox.Show("Divide-By-Zero error. Please enter a non-zero value for operand 2.", "Entry Error.")
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & vbCrLf &
                         ex.GetType.ToString & vbCrLf & vbCrLf &
                         ex.StackTrace, "Exception")
        End Try

        ' HANDS ON EXERCISE CODE ENDS HERE '

        ' HANDS ON EXERCISE CODE STARTS HERE '
        ' PART 2 - DATA VALIDATION


        ' HANDS ON EXERCISE CODE ENDS HERE '



    End Sub

    ' HANDS ON EXERCISE CODE STARTS HERE '
    ' ADD DATA VALIDATION FUNCTION HERE

    Private Function IsValidOperator(ByVal operatorString As String) As Boolean
        If operatorString = "+" Then
            Return True
        ElseIf operatorString = "-" Then
            Return True
        ElseIf operatorString = "*" Then
            Return True
        ElseIf operatorString = "/" Then
            Return True
        Else
            Return False
        End If
    End Function
    ' HANDS ON EXERCISE CODE ENDS HERE '


    Private Function CalculationResult(operand1 As Decimal,
            operator1 As String,
            operand2 As Decimal) As Decimal
        If operator1 = "+" Then
            CalculationResult = operand1 + operand2
        ElseIf operator1 = "-" Then
            CalculationResult = operand1 - operand2
        ElseIf operator1 = "*" Then
            CalculationResult = operand1 * operand2
        ElseIf operator1 = "/" Then
            CalculationResult = operand1 / operand2
        End If
        Return CalculationResult
    End Function

    Private Sub btnExit_Click(sender As Object,
            e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearResult(sender As Object,
            e As EventArgs) _
            Handles txtOperand1.TextChanged,
            txtOperator.TextChanged,
            txtOperand2.TextChanged
        txtResult.Text = ""
    End Sub

End Class
