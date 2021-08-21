<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrder
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoCustom = New System.Windows.Forms.RadioButton()
        Me.rdoDefault = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstOrderAmount = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpOrderDue = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLeadTime = New System.Windows.Forms.TextBox()
        Me.chkRepeat = New System.Windows.Forms.CheckBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product"
        '
        'txtProduct
        '
        Me.txtProduct.Location = New System.Drawing.Point(139, 44)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(500, 26)
        Me.txtProduct.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoCustom)
        Me.GroupBox1.Controls.Add(Me.rdoDefault)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(591, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order type"
        '
        'rdoCustom
        '
        Me.rdoCustom.AutoSize = True
        Me.rdoCustom.Location = New System.Drawing.Point(444, 42)
        Me.rdoCustom.Name = "rdoCustom"
        Me.rdoCustom.Size = New System.Drawing.Size(89, 24)
        Me.rdoCustom.TabIndex = 1
        Me.rdoCustom.TabStop = True
        Me.rdoCustom.Text = "Custom"
        Me.rdoCustom.UseVisualStyleBackColor = True
        '
        'rdoDefault
        '
        Me.rdoDefault.AutoSize = True
        Me.rdoDefault.Location = New System.Drawing.Point(49, 42)
        Me.rdoDefault.Name = "rdoDefault"
        Me.rdoDefault.Size = New System.Drawing.Size(86, 24)
        Me.rdoDefault.TabIndex = 0
        Me.rdoDefault.TabStop = True
        Me.rdoDefault.Text = "Default"
        Me.rdoDefault.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Order amount"
        '
        'lstOrderAmount
        '
        Me.lstOrderAmount.FormattingEnabled = True
        Me.lstOrderAmount.ItemHeight = 20
        Me.lstOrderAmount.Location = New System.Drawing.Point(52, 315)
        Me.lstOrderAmount.Name = "lstOrderAmount"
        Me.lstOrderAmount.Size = New System.Drawing.Size(131, 184)
        Me.lstOrderAmount.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(437, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Order due"
        '
        'dtpOrderDue
        '
        Me.dtpOrderDue.Location = New System.Drawing.Point(315, 315)
        Me.dtpOrderDue.Name = "dtpOrderDue"
        Me.dtpOrderDue.Size = New System.Drawing.Size(324, 26)
        Me.dtpOrderDue.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(315, 394)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Lead time"
        '
        'txtLeadTime
        '
        Me.txtLeadTime.Enabled = False
        Me.txtLeadTime.Location = New System.Drawing.Point(419, 394)
        Me.txtLeadTime.Name = "txtLeadTime"
        Me.txtLeadTime.Size = New System.Drawing.Size(220, 26)
        Me.txtLeadTime.TabIndex = 8
        '
        'chkRepeat
        '
        Me.chkRepeat.AutoSize = True
        Me.chkRepeat.Location = New System.Drawing.Point(315, 474)
        Me.chkRepeat.Name = "chkRepeat"
        Me.chkRepeat.Size = New System.Drawing.Size(210, 24)
        Me.chkRepeat.TabIndex = 9
        Me.chkRepeat.Text = "Repeat order periodically"
        Me.chkRepeat.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(52, 561)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(131, 52)
        Me.btnOk.TabIndex = 10
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(508, 561)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(131, 52)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 650)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.chkRepeat)
        Me.Controls.Add(Me.txtLeadTime)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpOrderDue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstOrderAmount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmOrder"
        Me.Text = "Order"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtProduct As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoCustom As RadioButton
    Friend WithEvents rdoDefault As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents lstOrderAmount As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpOrderDue As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLeadTime As TextBox
    Friend WithEvents chkRepeat As CheckBox
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
End Class
