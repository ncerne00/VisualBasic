Public Class frmCalculator

    ' IN CLASS CODE BEGINS HERE %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%



    ' IN CLASS CODE ENDS HERE %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    ' Displays results or appropriate error message.
    Private Sub DisplayResult()

        Dim resultString As String
        If err = 100 Then
            'resultString = FormatNumber(res, 2) ' FormatPercent, FormatCurrency
            resultString = res.ToString("n2") ' p2, c2
        Else
            resultString = err & ": " & errmsg

            ' increment number of errors by one (if initialized)
            If Not IsNothing(numErr) Then
                ' numErr = numErr + 1
                numErr += 1
                txtNumErr.Text = numErr.ToString
            Else
                txtNumErr.Text = "ERROR."
            End If
        End If
        txtResult.Text = resultString
    End Sub


    ' Event handlers for +, -, x, / buttons.
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ReadOperands()
        If err = 100 Then
            lblOperator.Text = "+"
            res = op1 + op2
        End If
        DisplayResult()
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        ReadOperands()
        If err = 100 Then
            lblOperator.Text = "-"
            res = op1 - op2
        End If
        DisplayResult()
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        ReadOperands()
        If err = 100 Then
            lblOperator.Text = "x"
            res = op1 * op2
        End If
        DisplayResult()
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        ReadOperands()
        If err = 100 Then
            lblOperator.Text = "/"
            If op2 = 0 Then
                err = ErrType.Div0
                errmsg = "Division by zero."
            Else
                res = op1 / op2
            End If
        End If
        DisplayResult()
    End Sub

    ' Event handler for Close button.
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
