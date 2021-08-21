<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmployeeListing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.employeeBoxLbl = New System.Windows.Forms.Label()
        Me.idLbl = New System.Windows.Forms.Label()
        Me.classLbl = New System.Windows.Forms.Label()
        Me.highestRateLbl = New System.Windows.Forms.Label()
        Me.projRateLbl = New System.Windows.Forms.Label()
        Me.clientLblOutput = New System.Windows.Forms.Label()
        Me.idLblOutput = New System.Windows.Forms.Label()
        Me.displayLblOutput = New System.Windows.Forms.Label()
        Me.classLblOutput = New System.Windows.Forms.Label()
        Me.displayNameLbl = New System.Windows.Forms.Label()
        Me.baseRateLbl = New System.Windows.Forms.Label()
        Me.baseRateLblOutput = New System.Windows.Forms.Label()
        Me.employeeBox = New System.Windows.Forms.ListBox()
        Me.rateBox = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'employeeBoxLbl
        '
        Me.employeeBoxLbl.AutoSize = True
        Me.employeeBoxLbl.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeBoxLbl.Location = New System.Drawing.Point(59, 282)
        Me.employeeBoxLbl.Name = "employeeBoxLbl"
        Me.employeeBoxLbl.Size = New System.Drawing.Size(222, 25)
        Me.employeeBoxLbl.TabIndex = 0
        Me.employeeBoxLbl.Text = "EMPLOYEE LISTING"
        '
        'idLbl
        '
        Me.idLbl.AutoSize = True
        Me.idLbl.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idLbl.Location = New System.Drawing.Point(444, 323)
        Me.idLbl.Name = "idLbl"
        Me.idLbl.Size = New System.Drawing.Size(31, 18)
        Me.idLbl.TabIndex = 1
        Me.idLbl.Text = "ID:"
        '
        'classLbl
        '
        Me.classLbl.AutoSize = True
        Me.classLbl.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classLbl.Location = New System.Drawing.Point(444, 381)
        Me.classLbl.Name = "classLbl"
        Me.classLbl.Size = New System.Drawing.Size(115, 18)
        Me.classLbl.TabIndex = 2
        Me.classLbl.Text = "Classification:"
        '
        'highestRateLbl
        '
        Me.highestRateLbl.AutoSize = True
        Me.highestRateLbl.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.highestRateLbl.Location = New System.Drawing.Point(450, 655)
        Me.highestRateLbl.Name = "highestRateLbl"
        Me.highestRateLbl.Size = New System.Drawing.Size(157, 18)
        Me.highestRateLbl.TabIndex = 3
        Me.highestRateLbl.Text = "Highest Rate Client:"
        '
        'projRateLbl
        '
        Me.projRateLbl.AutoSize = True
        Me.projRateLbl.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projRateLbl.Location = New System.Drawing.Point(447, 447)
        Me.projRateLbl.Name = "projRateLbl"
        Me.projRateLbl.Size = New System.Drawing.Size(109, 18)
        Me.projRateLbl.TabIndex = 4
        Me.projRateLbl.Text = "Project Rates"
        '
        'clientLblOutput
        '
        Me.clientLblOutput.AutoSize = True
        Me.clientLblOutput.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientLblOutput.Location = New System.Drawing.Point(613, 655)
        Me.clientLblOutput.Name = "clientLblOutput"
        Me.clientLblOutput.Size = New System.Drawing.Size(80, 18)
        Me.clientLblOutput.TabIndex = 5
        Me.clientLblOutput.Text = "placeholder"
        Me.clientLblOutput.Visible = False
        '
        'idLblOutput
        '
        Me.idLblOutput.AutoSize = True
        Me.idLblOutput.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idLblOutput.Location = New System.Drawing.Point(613, 323)
        Me.idLblOutput.Name = "idLblOutput"
        Me.idLblOutput.Size = New System.Drawing.Size(80, 18)
        Me.idLblOutput.TabIndex = 6
        Me.idLblOutput.Text = "placeholder"
        Me.idLblOutput.Visible = False
        '
        'displayLblOutput
        '
        Me.displayLblOutput.AutoSize = True
        Me.displayLblOutput.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayLblOutput.Location = New System.Drawing.Point(613, 354)
        Me.displayLblOutput.Name = "displayLblOutput"
        Me.displayLblOutput.Size = New System.Drawing.Size(80, 18)
        Me.displayLblOutput.TabIndex = 7
        Me.displayLblOutput.Text = "placeholder"
        Me.displayLblOutput.Visible = False
        '
        'classLblOutput
        '
        Me.classLblOutput.AutoSize = True
        Me.classLblOutput.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classLblOutput.Location = New System.Drawing.Point(613, 381)
        Me.classLblOutput.Name = "classLblOutput"
        Me.classLblOutput.Size = New System.Drawing.Size(80, 18)
        Me.classLblOutput.TabIndex = 8
        Me.classLblOutput.Text = "placeholder"
        Me.classLblOutput.Visible = False
        '
        'displayNameLbl
        '
        Me.displayNameLbl.AutoSize = True
        Me.displayNameLbl.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayNameLbl.Location = New System.Drawing.Point(444, 354)
        Me.displayNameLbl.Name = "displayNameLbl"
        Me.displayNameLbl.Size = New System.Drawing.Size(116, 18)
        Me.displayNameLbl.TabIndex = 9
        Me.displayNameLbl.Text = "Display Name:"
        '
        'baseRateLbl
        '
        Me.baseRateLbl.AutoSize = True
        Me.baseRateLbl.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.baseRateLbl.Location = New System.Drawing.Point(444, 405)
        Me.baseRateLbl.Name = "baseRateLbl"
        Me.baseRateLbl.Size = New System.Drawing.Size(88, 18)
        Me.baseRateLbl.TabIndex = 10
        Me.baseRateLbl.Text = "Base Rate:"
        '
        'baseRateLblOutput
        '
        Me.baseRateLblOutput.AutoSize = True
        Me.baseRateLblOutput.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.baseRateLblOutput.Location = New System.Drawing.Point(613, 405)
        Me.baseRateLblOutput.Name = "baseRateLblOutput"
        Me.baseRateLblOutput.Size = New System.Drawing.Size(80, 18)
        Me.baseRateLblOutput.TabIndex = 11
        Me.baseRateLblOutput.Text = "placeholder"
        Me.baseRateLblOutput.Visible = False
        '
        'employeeBox
        '
        Me.employeeBox.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeBox.FormattingEnabled = True
        Me.employeeBox.ItemHeight = 18
        Me.employeeBox.Location = New System.Drawing.Point(37, 310)
        Me.employeeBox.Name = "employeeBox"
        Me.employeeBox.Size = New System.Drawing.Size(291, 364)
        Me.employeeBox.TabIndex = 12
        '
        'rateBox
        '
        Me.rateBox.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rateBox.FormattingEnabled = True
        Me.rateBox.ItemHeight = 18
        Me.rateBox.Location = New System.Drawing.Point(576, 447)
        Me.rateBox.Name = "rateBox"
        Me.rateBox.Size = New System.Drawing.Size(231, 184)
        Me.rateBox.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HW5.My.Resources.Resources.kevinsdisaster
        Me.PictureBox1.Location = New System.Drawing.Point(328, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(479, 269)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'frmEmployeeListing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1114, 702)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.rateBox)
        Me.Controls.Add(Me.employeeBox)
        Me.Controls.Add(Me.baseRateLblOutput)
        Me.Controls.Add(Me.baseRateLbl)
        Me.Controls.Add(Me.displayNameLbl)
        Me.Controls.Add(Me.classLblOutput)
        Me.Controls.Add(Me.displayLblOutput)
        Me.Controls.Add(Me.idLblOutput)
        Me.Controls.Add(Me.clientLblOutput)
        Me.Controls.Add(Me.projRateLbl)
        Me.Controls.Add(Me.highestRateLbl)
        Me.Controls.Add(Me.classLbl)
        Me.Controls.Add(Me.idLbl)
        Me.Controls.Add(Me.employeeBoxLbl)
        Me.Name = "frmEmployeeListing"
        Me.Text = "Employees - Details"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents employeeBoxLbl As Label
    Friend WithEvents idLbl As Label
    Friend WithEvents classLbl As Label
    Friend WithEvents highestRateLbl As Label
    Friend WithEvents projRateLbl As Label
    Friend WithEvents clientLblOutput As Label
    Friend WithEvents idLblOutput As Label
    Friend WithEvents displayLblOutput As Label
    Friend WithEvents classLblOutput As Label
    Friend WithEvents displayNameLbl As Label
    Friend WithEvents baseRateLbl As Label
    Friend WithEvents baseRateLblOutput As Label
    Friend WithEvents employeeBox As ListBox
    Friend WithEvents rateBox As ListBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
