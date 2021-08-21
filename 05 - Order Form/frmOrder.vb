Public Class frmOrder

    Public Property NewOrder As New Order

    Public product As String

    ' Load event handler
    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtProduct.Text = NewOrder.Product
        FillOrderAmount()
        SetDefaultValues()
        rdoDefault.Checked = True
        EnableDisableCustom(rdoCustom.Checked)
    End Sub

    ' HANDS ON EXERCISE SECTION 2 CODE BEGINS HERE %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    Private Sub FillOrderAmount()
        lstOrderAmount.Items.Clear()
        For i As Integer = 1 To 10
            lstOrderAmount.Items.Add(i * 10)
        Next
    End Sub


    Private Sub SetDefaultValues()
        lstOrderAmount.SelectedIndex = 0
        dtpOrderDue.Value = Now.AddDays(7)
        chkRepeat.Checked = False
    End Sub

    Private Sub EnableDisableCustom(switch As Boolean)
        lstOrderAmount.Enabled = switch
        dtpOrderDue.Enabled = switch
        chkRepeat.Enabled = switch

    End Sub
    ' HANDS ON EXERCISE SECTION 2 CODE ENDS HERE %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    ' set default values if rdoDefault is selected
    Private Sub rdoDefault_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDefault.CheckedChanged
        If rdoDefault.Checked Then
            SetDefaultValues()
        End If
        EnableDisableCustom(rdoCustom.Checked)
    End Sub

    ' check due date, make sure it is not before now, set lead time
    Private Sub CheckDueDate()
        Try
            Dim dueDate As Date = dtpOrderDue.Value
            If dueDate < Now Then
                Throw New Exception("Due date cannot be earlier than now.")
            End If
            Dim timeTillDue As TimeSpan = dtpOrderDue.Value.Subtract(Now)
            txtLeadTime.Text = timeTillDue.Days & " days"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Date error")
        End Try
    End Sub

    ' check due date whenever a new date is selected
    Private Sub dtpOrderDue_ValueChanged(sender As Object, e As EventArgs) Handles dtpOrderDue.ValueChanged
        If Not Order.IsValidDueDate(dtpOrderDue) Then
            dtpOrderDue.Value = NewOrder.OrderDue
        Else
            NewOrder.OrderDue = dtpOrderDue.Value
            Dim daysTillDue As TimeSpan = dtpOrderDue.Value.Subtract(Now)
            txtLeadTime.Text = daysTillDue.Days & " days"
        End If

    End Sub

    ' create a record of the order, pass it to Tag property of form
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        NewOrder.OrderAmount = CInt(lstOrderAmount.Text)
        NewOrder.OrderDate = Now
        NewOrder.OrderDue = dtpOrderDue.Value
        NewOrder.LeadTime = NewOrder.OrderDue.Subtract(NewOrder.OrderDate)
        NewOrder.IsDefault = rdoDefault.Checked
        NewOrder.IsRepeated = chkRepeat.Checked

        Me.Tag = NewOrder.GetOrderSummary
        Me.DialogResult = DialogResult.OK
    End Sub

    ' close form
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class