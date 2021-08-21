<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator
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
        Me.txtOperand1 = New System.Windows.Forms.TextBox()
        Me.txtOperand2 = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.lblOperator = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumErr = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOperand1
        '
        Me.txtOperand1.Location = New System.Drawing.Point(43, 43)
        Me.txtOperand1.Name = "txtOperand1"
        Me.txtOperand1.Size = New System.Drawing.Size(201, 26)
        Me.txtOperand1.TabIndex = 0
        Me.txtOperand1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOperand2
        '
        Me.txtOperand2.Location = New System.Drawing.Point(43, 115)
        Me.txtOperand2.Name = "txtOperand2"
        Me.txtOperand2.Size = New System.Drawing.Size(201, 26)
        Me.txtOperand2.TabIndex = 2
        Me.txtOperand2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtResult
        '
        Me.txtResult.Enabled = False
        Me.txtResult.Location = New System.Drawing.Point(43, 191)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(201, 26)
        Me.txtResult.TabIndex = 4
        Me.txtResult.TabStop = False
        Me.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(265, 43)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(68, 39)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Location = New System.Drawing.Point(265, 88)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(68, 39)
        Me.btnSubtract.TabIndex = 6
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(265, 133)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(68, 39)
        Me.btnMultiply.TabIndex = 7
        Me.btnMultiply.Text = "x"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(265, 178)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(68, 39)
        Me.btnDivide.TabIndex = 8
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'lblOperator
        '
        Me.lblOperator.AutoSize = True
        Me.lblOperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperator.Location = New System.Drawing.Point(133, 79)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.Size = New System.Drawing.Size(0, 29)
        Me.lblOperator.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(133, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "="
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 273)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Number of errors commited:"
        '
        'txtNumErr
        '
        Me.txtNumErr.Enabled = False
        Me.txtNumErr.Location = New System.Drawing.Point(265, 270)
        Me.txtNumErr.Name = "txtNumErr"
        Me.txtNumErr.Size = New System.Drawing.Size(68, 26)
        Me.txtNumErr.TabIndex = 10
        Me.txtNumErr.TabStop = False
        Me.txtNumErr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(265, 324)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(68, 45)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmCalculator
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(377, 396)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtNumErr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblOperator)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtOperand2)
        Me.Controls.Add(Me.txtOperand1)
        Me.Name = "frmCalculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOperand1 As TextBox
    Friend WithEvents txtOperand2 As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents lblOperator As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumErr As TextBox
    Friend WithEvents btnClose As Button
End Class
