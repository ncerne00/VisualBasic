<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class demographicForm
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
        Me.fNameBox = New System.Windows.Forms.TextBox()
        Me.lNameBox = New System.Windows.Forms.TextBox()
        Me.ageBox = New System.Windows.Forms.TextBox()
        Me.firstNameLabel = New System.Windows.Forms.Label()
        Me.lstNameLabel = New System.Windows.Forms.Label()
        Me.ageLabel = New System.Windows.Forms.Label()
        Me.outputLabel = New System.Windows.Forms.Label()
        Me.enterBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'fNameBox
        '
        Me.fNameBox.Location = New System.Drawing.Point(71, 51)
        Me.fNameBox.Name = "fNameBox"
        Me.fNameBox.Size = New System.Drawing.Size(104, 20)
        Me.fNameBox.TabIndex = 0
        '
        'lNameBox
        '
        Me.lNameBox.Location = New System.Drawing.Point(71, 77)
        Me.lNameBox.Name = "lNameBox"
        Me.lNameBox.Size = New System.Drawing.Size(104, 20)
        Me.lNameBox.TabIndex = 1
        '
        'ageBox
        '
        Me.ageBox.Location = New System.Drawing.Point(71, 103)
        Me.ageBox.Name = "ageBox"
        Me.ageBox.Size = New System.Drawing.Size(36, 20)
        Me.ageBox.TabIndex = 2
        '
        'firstNameLabel
        '
        Me.firstNameLabel.AutoSize = True
        Me.firstNameLabel.Location = New System.Drawing.Point(12, 54)
        Me.firstNameLabel.Name = "firstNameLabel"
        Me.firstNameLabel.Size = New System.Drawing.Size(57, 13)
        Me.firstNameLabel.TabIndex = 3
        Me.firstNameLabel.Text = "First Name"
        '
        'lstNameLabel
        '
        Me.lstNameLabel.AutoSize = True
        Me.lstNameLabel.Location = New System.Drawing.Point(12, 84)
        Me.lstNameLabel.Name = "lstNameLabel"
        Me.lstNameLabel.Size = New System.Drawing.Size(58, 13)
        Me.lstNameLabel.TabIndex = 4
        Me.lstNameLabel.Text = "Last Name"
        '
        'ageLabel
        '
        Me.ageLabel.AutoSize = True
        Me.ageLabel.Location = New System.Drawing.Point(24, 110)
        Me.ageLabel.Name = "ageLabel"
        Me.ageLabel.Size = New System.Drawing.Size(26, 13)
        Me.ageLabel.TabIndex = 5
        Me.ageLabel.Text = "Age"
        '
        'outputLabel
        '
        Me.outputLabel.AutoSize = True
        Me.outputLabel.BackColor = System.Drawing.Color.White
        Me.outputLabel.Location = New System.Drawing.Point(213, 51)
        Me.outputLabel.MinimumSize = New System.Drawing.Size(269, 150)
        Me.outputLabel.Name = "outputLabel"
        Me.outputLabel.Size = New System.Drawing.Size(269, 150)
        Me.outputLabel.TabIndex = 7
        '
        'enterBtn
        '
        Me.enterBtn.BackColor = System.Drawing.Color.Aquamarine
        Me.enterBtn.Location = New System.Drawing.Point(72, 222)
        Me.enterBtn.Name = "enterBtn"
        Me.enterBtn.Size = New System.Drawing.Size(75, 23)
        Me.enterBtn.TabIndex = 8
        Me.enterBtn.Text = "Enter"
        Me.enterBtn.UseVisualStyleBackColor = False
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(417, 222)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(75, 23)
        Me.exitBtn.TabIndex = 9
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'demographicForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 277)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.enterBtn)
        Me.Controls.Add(Me.outputLabel)
        Me.Controls.Add(Me.ageLabel)
        Me.Controls.Add(Me.lstNameLabel)
        Me.Controls.Add(Me.firstNameLabel)
        Me.Controls.Add(Me.ageBox)
        Me.Controls.Add(Me.lNameBox)
        Me.Controls.Add(Me.fNameBox)
        Me.Name = "demographicForm"
        Me.Text = "Demographic Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fNameBox As TextBox
    Friend WithEvents lNameBox As TextBox
    Friend WithEvents ageBox As TextBox
    Friend WithEvents firstNameLabel As Label
    Friend WithEvents lstNameLabel As Label
    Friend WithEvents ageLabel As Label
    Friend WithEvents outputLabel As Label
    Friend WithEvents enterBtn As Button
    Friend WithEvents exitBtn As Button
End Class
