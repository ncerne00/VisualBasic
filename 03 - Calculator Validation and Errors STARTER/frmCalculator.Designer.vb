<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOperand2 = New System.Windows.Forms.TextBox()
        Me.txtOperator = New System.Windows.Forms.TextBox()
        Me.txtOperand1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(120, 152)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 24)
        Me.btnExit.TabIndex = 39
        Me.btnExit.Text = "E&xit"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(32, 152)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(80, 24)
        Me.btnCalculate.TabIndex = 38
        Me.btnCalculate.Text = "&Calculate"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(32, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Result:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOperand2
        '
        Me.txtOperand2.Location = New System.Drawing.Point(120, 88)
        Me.txtOperand2.Name = "txtOperand2"
        Me.txtOperand2.Size = New System.Drawing.Size(72, 20)
        Me.txtOperand2.TabIndex = 35
        '
        'txtOperator
        '
        Me.txtOperator.Location = New System.Drawing.Point(120, 56)
        Me.txtOperator.Name = "txtOperator"
        Me.txtOperator.Size = New System.Drawing.Size(24, 20)
        Me.txtOperator.TabIndex = 34
        '
        'txtOperand1
        '
        Me.txtOperand1.Location = New System.Drawing.Point(120, 24)
        Me.txtOperand1.Name = "txtOperand1"
        Me.txtOperand1.Size = New System.Drawing.Size(72, 20)
        Me.txtOperand1.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Operand 2:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Operator:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Operand 1:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(120, 115)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(72, 20)
        Me.txtResult.TabIndex = 40
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(229, 198)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOperand2)
        Me.Controls.Add(Me.txtOperator)
        Me.Controls.Add(Me.txtOperand1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOperand2 As System.Windows.Forms.TextBox
    Friend WithEvents txtOperator As System.Windows.Forms.TextBox
    Friend WithEvents txtOperand1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtResult As System.Windows.Forms.TextBox

End Class
