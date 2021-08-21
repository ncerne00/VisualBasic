Public Class frmProduct

    Public Property OrderList As New List(Of Order)

    ' populate cboProduct and set time when form loads
    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDateTime.Text = Now
        cboProduct.Items.Add("ModelX")
        cboProduct.Items.Add("ModelY")
        cboProduct.Items.Add("ModelZ")
        cboProduct.SelectedIndex = 0
    End Sub

    ' close form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ' to show current time in real-time
    Private Sub tmrNow_Tick(sender As Object, e As EventArgs) Handles tmrNow.Tick
        txtDateTime.Text = Format(Now, "MM/dd/yyy hh:mm:ss")
    End Sub

    ' HANDS ON EXERCISE SECTION 1 CODE BEGINS HERE %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Dim orderForm As New frmOrder
        orderForm.NewOrder.Product = cboProduct.Text


        Dim selectedButton As DialogResult = orderForm.ShowDialog()

        If selectedButton = DialogResult.OK Then
            OrderList.Add(orderForm.NewOrder)
            orderForm.NewOrder.ID = "ORD#" & OrderList.Count
            lblOrder.Text = orderForm.NewOrder.GetOrderSummary(orderForm.NewOrder.ID)
            lstOrders.Items.Add(orderForm.NewOrder.ID)
            lstOrders.SelectedIndex = lstOrders.Items.Count - 1
        End If
    End Sub


    ' HANDS ON EXERCISE SECTION 1 CODE ENDS HERE %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    ' display order summary of selected order
    Private Sub lstOrders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOrders.SelectedIndexChanged
        lblOrder.Text = OrderList(lstOrders.SelectedIndex).GetOrderSummary(lstOrders.Text)
    End Sub


End Class
