<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDateTime = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboProduct = New System.Windows.Forms.ComboBox()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lstOrders = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tmrNow = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current day/time"
        '
        'txtDateTime
        '
        Me.txtDateTime.Enabled = False
        Me.txtDateTime.Location = New System.Drawing.Point(125, 25)
        Me.txtDateTime.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDateTime.Name = "txtDateTime"
        Me.txtDateTime.Size = New System.Drawing.Size(245, 20)
        Me.txtDateTime.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Product"
        '
        'cboProduct
        '
        Me.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProduct.FormattingEnabled = True
        Me.cboProduct.Location = New System.Drawing.Point(125, 83)
        Me.cboProduct.Margin = New System.Windows.Forms.Padding(2)
        Me.cboProduct.Name = "cboProduct"
        Me.cboProduct.Size = New System.Drawing.Size(245, 21)
        Me.cboProduct.TabIndex = 4
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(389, 77)
        Me.btnOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(58, 30)
        Me.btnOrder.TabIndex = 5
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'lblOrder
        '
        Me.lblOrder.BackColor = System.Drawing.Color.White
        Me.lblOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOrder.Location = New System.Drawing.Point(126, 148)
        Me.lblOrder.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(244, 121)
        Me.lblOrder.TabIndex = 7
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(389, 288)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(58, 30)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lstOrders
        '
        Me.lstOrders.FormattingEnabled = True
        Me.lstOrders.Location = New System.Drawing.Point(30, 148)
        Me.lstOrders.Name = "lstOrders"
        Me.lstOrders.Size = New System.Drawing.Size(82, 121)
        Me.lstOrders.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Orders"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(122, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Order Summary"
        '
        'tmrNow
        '
        Me.tmrNow.Enabled = True
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 342)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstOrders)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.cboProduct)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDateTime)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmProduct"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDateTime As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboProduct As ComboBox
    Friend WithEvents btnOrder As Button
    Friend WithEvents lblOrder As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents lstOrders As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tmrNow As Timer
End Class
