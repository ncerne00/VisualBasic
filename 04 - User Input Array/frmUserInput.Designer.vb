<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserInput
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
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTicker = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmployees = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMarketCap = New System.Windows.Forms.TextBox()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Company"
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(81, 19)
        Me.txtCompany.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(92, 20)
        Me.txtCompany.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ticker"
        '
        'txtTicker
        '
        Me.txtTicker.Location = New System.Drawing.Point(81, 45)
        Me.txtTicker.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTicker.Name = "txtTicker"
        Me.txtTicker.Size = New System.Drawing.Size(92, 20)
        Me.txtTicker.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Employees"
        '
        'txtEmployees
        '
        Me.txtEmployees.Location = New System.Drawing.Point(82, 96)
        Me.txtEmployees.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmployees.Name = "txtEmployees"
        Me.txtEmployees.Size = New System.Drawing.Size(92, 20)
        Me.txtEmployees.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 70)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Market cap"
        '
        'txtMarketCap
        '
        Me.txtMarketCap.Location = New System.Drawing.Point(81, 69)
        Me.txtMarketCap.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMarketCap.Name = "txtMarketCap"
        Me.txtMarketCap.Size = New System.Drawing.Size(92, 20)
        Me.txtMarketCap.TabIndex = 5
        '
        'lblDatabase
        '
        Me.lblDatabase.BackColor = System.Drawing.Color.White
        Me.lblDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDatabase.Enabled = False
        Me.lblDatabase.Location = New System.Drawing.Point(221, 19)
        Me.lblDatabase.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(269, 147)
        Me.lblDatabase.TabIndex = 13
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(81, 189)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(91, 28)
        Me.btnEnter.TabIndex = 9
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(434, 189)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(56, 28)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(176, 73)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "billion"
        '
        'frmUserInput
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(519, 228)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblDatabase)
        Me.Controls.Add(Me.txtMarketCap)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmployees)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTicker)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmUserInput"
        Me.Text = "User Input"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTicker As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmployees As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMarketCap As TextBox
    Friend WithEvents lblDatabase As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label7 As Label
End Class
