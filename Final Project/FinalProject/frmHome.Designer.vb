<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
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
        Me.optimizeBtn = New System.Windows.Forms.Button()
        Me.demoBtn = New System.Windows.Forms.RadioButton()
        Me.realBtn = New System.Windows.Forms.RadioButton()
        Me.totalStaffingCostLbl = New System.Windows.Forms.Label()
        Me.totalStaffingCostLblOutput = New System.Windows.Forms.Label()
        Me.tabForm = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.staffDetailsBox = New System.Windows.Forms.GroupBox()
        Me.nameLbl = New System.Windows.Forms.Label()
        Me.weeklyHoursLbl = New System.Windows.Forms.Label()
        Me.hoursTree = New System.Windows.Forms.TreeView()
        Me.classificationLbl = New System.Windows.Forms.Label()
        Me.baseRateLbl = New System.Windows.Forms.Label()
        Me.assignedProjBox = New System.Windows.Forms.ListBox()
        Me.assignedProjLbl = New System.Windows.Forms.Label()
        Me.idleHoursLbl = New System.Windows.Forms.Label()
        Me.workingHoursLbl = New System.Windows.Forms.Label()
        Me.staffBox = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.projDetails = New System.Windows.Forms.GroupBox()
        Me.assignedStaffBox = New System.Windows.Forms.ListBox()
        Me.assignedStaffLbl = New System.Windows.Forms.Label()
        Me.profitMarginLbl = New System.Windows.Forms.Label()
        Me.projCostLbl = New System.Windows.Forms.Label()
        Me.industryLbl = New System.Windows.Forms.Label()
        Me.projRevenueLbl = New System.Windows.Forms.Label()
        Me.companyNameLbl = New System.Windows.Forms.Label()
        Me.projBox = New System.Windows.Forms.ListBox()
        Me.officePic = New System.Windows.Forms.PictureBox()
        Me.tabForm.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.staffDetailsBox.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.projDetails.SuspendLayout()
        CType(Me.officePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'optimizeBtn
        '
        Me.optimizeBtn.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optimizeBtn.Location = New System.Drawing.Point(202, 244)
        Me.optimizeBtn.Name = "optimizeBtn"
        Me.optimizeBtn.Size = New System.Drawing.Size(137, 58)
        Me.optimizeBtn.TabIndex = 0
        Me.optimizeBtn.Text = "Optimize"
        Me.optimizeBtn.UseVisualStyleBackColor = True
        '
        'demoBtn
        '
        Me.demoBtn.AutoSize = True
        Me.demoBtn.Checked = True
        Me.demoBtn.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.demoBtn.Location = New System.Drawing.Point(70, 244)
        Me.demoBtn.Name = "demoBtn"
        Me.demoBtn.Size = New System.Drawing.Size(106, 26)
        Me.demoBtn.TabIndex = 1
        Me.demoBtn.TabStop = True
        Me.demoBtn.Text = "Demo Data"
        Me.demoBtn.UseVisualStyleBackColor = True
        '
        'realBtn
        '
        Me.realBtn.AutoSize = True
        Me.realBtn.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.realBtn.Location = New System.Drawing.Point(70, 276)
        Me.realBtn.Name = "realBtn"
        Me.realBtn.Size = New System.Drawing.Size(94, 26)
        Me.realBtn.TabIndex = 2
        Me.realBtn.Text = "Real Data"
        Me.realBtn.UseVisualStyleBackColor = True
        '
        'totalStaffingCostLbl
        '
        Me.totalStaffingCostLbl.AutoSize = True
        Me.totalStaffingCostLbl.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalStaffingCostLbl.Location = New System.Drawing.Point(510, 244)
        Me.totalStaffingCostLbl.Name = "totalStaffingCostLbl"
        Me.totalStaffingCostLbl.Size = New System.Drawing.Size(191, 27)
        Me.totalStaffingCostLbl.TabIndex = 3
        Me.totalStaffingCostLbl.Text = "Total Staffing Cost:"
        '
        'totalStaffingCostLblOutput
        '
        Me.totalStaffingCostLblOutput.AutoSize = True
        Me.totalStaffingCostLblOutput.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalStaffingCostLblOutput.Location = New System.Drawing.Point(707, 244)
        Me.totalStaffingCostLblOutput.Name = "totalStaffingCostLblOutput"
        Me.totalStaffingCostLblOutput.Size = New System.Drawing.Size(48, 27)
        Me.totalStaffingCostLblOutput.TabIndex = 4
        Me.totalStaffingCostLblOutput.Text = "N/A"
        '
        'tabForm
        '
        Me.tabForm.Controls.Add(Me.TabPage1)
        Me.tabForm.Controls.Add(Me.TabPage2)
        Me.tabForm.Enabled = False
        Me.tabForm.Location = New System.Drawing.Point(-1, 308)
        Me.tabForm.Name = "tabForm"
        Me.tabForm.SelectedIndex = 0
        Me.tabForm.Size = New System.Drawing.Size(939, 456)
        Me.tabForm.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.staffDetailsBox)
        Me.TabPage1.Controls.Add(Me.staffBox)
        Me.TabPage1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(931, 430)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Staff"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'staffDetailsBox
        '
        Me.staffDetailsBox.Controls.Add(Me.nameLbl)
        Me.staffDetailsBox.Controls.Add(Me.weeklyHoursLbl)
        Me.staffDetailsBox.Controls.Add(Me.hoursTree)
        Me.staffDetailsBox.Controls.Add(Me.classificationLbl)
        Me.staffDetailsBox.Controls.Add(Me.baseRateLbl)
        Me.staffDetailsBox.Controls.Add(Me.assignedProjBox)
        Me.staffDetailsBox.Controls.Add(Me.assignedProjLbl)
        Me.staffDetailsBox.Controls.Add(Me.idleHoursLbl)
        Me.staffDetailsBox.Controls.Add(Me.workingHoursLbl)
        Me.staffDetailsBox.Location = New System.Drawing.Point(244, 6)
        Me.staffDetailsBox.Name = "staffDetailsBox"
        Me.staffDetailsBox.Size = New System.Drawing.Size(630, 413)
        Me.staffDetailsBox.TabIndex = 12
        Me.staffDetailsBox.TabStop = False
        Me.staffDetailsBox.Text = "Staff Details"
        '
        'nameLbl
        '
        Me.nameLbl.AutoSize = True
        Me.nameLbl.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLbl.Location = New System.Drawing.Point(12, 33)
        Me.nameLbl.Name = "nameLbl"
        Me.nameLbl.Size = New System.Drawing.Size(47, 18)
        Me.nameLbl.TabIndex = 2
        Me.nameLbl.Text = "Name:"
        '
        'weeklyHoursLbl
        '
        Me.weeklyHoursLbl.AutoSize = True
        Me.weeklyHoursLbl.Location = New System.Drawing.Point(406, 58)
        Me.weeklyHoursLbl.Name = "weeklyHoursLbl"
        Me.weeklyHoursLbl.Size = New System.Drawing.Size(203, 22)
        Me.weeklyHoursLbl.TabIndex = 10
        Me.weeklyHoursLbl.Text = "Weekly Hours Breakdown"
        '
        'hoursTree
        '
        Me.hoursTree.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hoursTree.Location = New System.Drawing.Point(410, 83)
        Me.hoursTree.Name = "hoursTree"
        Me.hoursTree.Size = New System.Drawing.Size(187, 297)
        Me.hoursTree.TabIndex = 11
        '
        'classificationLbl
        '
        Me.classificationLbl.AutoSize = True
        Me.classificationLbl.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classificationLbl.Location = New System.Drawing.Point(12, 63)
        Me.classificationLbl.Name = "classificationLbl"
        Me.classificationLbl.Size = New System.Drawing.Size(95, 18)
        Me.classificationLbl.TabIndex = 3
        Me.classificationLbl.Text = "Classification:"
        '
        'baseRateLbl
        '
        Me.baseRateLbl.AutoSize = True
        Me.baseRateLbl.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.baseRateLbl.Location = New System.Drawing.Point(12, 91)
        Me.baseRateLbl.Name = "baseRateLbl"
        Me.baseRateLbl.Size = New System.Drawing.Size(72, 18)
        Me.baseRateLbl.TabIndex = 4
        Me.baseRateLbl.Text = "Base Rate:"
        '
        'assignedProjBox
        '
        Me.assignedProjBox.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.assignedProjBox.FormattingEnabled = True
        Me.assignedProjBox.ItemHeight = 18
        Me.assignedProjBox.Location = New System.Drawing.Point(59, 250)
        Me.assignedProjBox.Name = "assignedProjBox"
        Me.assignedProjBox.Size = New System.Drawing.Size(272, 130)
        Me.assignedProjBox.TabIndex = 7
        '
        'assignedProjLbl
        '
        Me.assignedProjLbl.AutoSize = True
        Me.assignedProjLbl.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.assignedProjLbl.Location = New System.Drawing.Point(116, 225)
        Me.assignedProjLbl.Name = "assignedProjLbl"
        Me.assignedProjLbl.Size = New System.Drawing.Size(144, 22)
        Me.assignedProjLbl.TabIndex = 8
        Me.assignedProjLbl.Text = "Assigned Projects"
        '
        'idleHoursLbl
        '
        Me.idleHoursLbl.AutoSize = True
        Me.idleHoursLbl.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idleHoursLbl.Location = New System.Drawing.Point(12, 116)
        Me.idleHoursLbl.Name = "idleHoursLbl"
        Me.idleHoursLbl.Size = New System.Drawing.Size(76, 18)
        Me.idleHoursLbl.TabIndex = 5
        Me.idleHoursLbl.Text = "Idle Hours:"
        '
        'workingHoursLbl
        '
        Me.workingHoursLbl.AutoSize = True
        Me.workingHoursLbl.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.workingHoursLbl.Location = New System.Drawing.Point(12, 148)
        Me.workingHoursLbl.Name = "workingHoursLbl"
        Me.workingHoursLbl.Size = New System.Drawing.Size(104, 18)
        Me.workingHoursLbl.TabIndex = 6
        Me.workingHoursLbl.Text = "Working Hours:"
        '
        'staffBox
        '
        Me.staffBox.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staffBox.FormattingEnabled = True
        Me.staffBox.ItemHeight = 18
        Me.staffBox.Location = New System.Drawing.Point(20, 22)
        Me.staffBox.Name = "staffBox"
        Me.staffBox.Size = New System.Drawing.Size(204, 364)
        Me.staffBox.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.projDetails)
        Me.TabPage2.Controls.Add(Me.projBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(931, 430)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Project"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'projDetails
        '
        Me.projDetails.Controls.Add(Me.assignedStaffBox)
        Me.projDetails.Controls.Add(Me.assignedStaffLbl)
        Me.projDetails.Controls.Add(Me.profitMarginLbl)
        Me.projDetails.Controls.Add(Me.projCostLbl)
        Me.projDetails.Controls.Add(Me.industryLbl)
        Me.projDetails.Controls.Add(Me.projRevenueLbl)
        Me.projDetails.Controls.Add(Me.companyNameLbl)
        Me.projDetails.Location = New System.Drawing.Point(317, 53)
        Me.projDetails.Name = "projDetails"
        Me.projDetails.Size = New System.Drawing.Size(303, 405)
        Me.projDetails.TabIndex = 1
        Me.projDetails.TabStop = False
        Me.projDetails.Text = "Project Details"
        '
        'assignedStaffBox
        '
        Me.assignedStaffBox.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.assignedStaffBox.FormattingEnabled = True
        Me.assignedStaffBox.ItemHeight = 18
        Me.assignedStaffBox.Location = New System.Drawing.Point(22, 279)
        Me.assignedStaffBox.Name = "assignedStaffBox"
        Me.assignedStaffBox.Size = New System.Drawing.Size(241, 94)
        Me.assignedStaffBox.TabIndex = 6
        '
        'assignedStaffLbl
        '
        Me.assignedStaffLbl.AutoSize = True
        Me.assignedStaffLbl.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.assignedStaffLbl.Location = New System.Drawing.Point(80, 254)
        Me.assignedStaffLbl.Name = "assignedStaffLbl"
        Me.assignedStaffLbl.Size = New System.Drawing.Size(116, 22)
        Me.assignedStaffLbl.TabIndex = 5
        Me.assignedStaffLbl.Text = "Assigned Staff"
        '
        'profitMarginLbl
        '
        Me.profitMarginLbl.AutoSize = True
        Me.profitMarginLbl.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profitMarginLbl.Location = New System.Drawing.Point(25, 169)
        Me.profitMarginLbl.Name = "profitMarginLbl"
        Me.profitMarginLbl.Size = New System.Drawing.Size(94, 18)
        Me.profitMarginLbl.TabIndex = 4
        Me.profitMarginLbl.Text = "Profit Margin:"
        '
        'projCostLbl
        '
        Me.projCostLbl.AutoSize = True
        Me.projCostLbl.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projCostLbl.Location = New System.Drawing.Point(25, 137)
        Me.projCostLbl.Name = "projCostLbl"
        Me.projCostLbl.Size = New System.Drawing.Size(88, 18)
        Me.projCostLbl.TabIndex = 3
        Me.projCostLbl.Text = "Project Cost:"
        '
        'industryLbl
        '
        Me.industryLbl.AutoSize = True
        Me.industryLbl.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.industryLbl.Location = New System.Drawing.Point(25, 104)
        Me.industryLbl.Name = "industryLbl"
        Me.industryLbl.Size = New System.Drawing.Size(65, 18)
        Me.industryLbl.TabIndex = 2
        Me.industryLbl.Text = "Industry:"
        '
        'projRevenueLbl
        '
        Me.projRevenueLbl.AutoSize = True
        Me.projRevenueLbl.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projRevenueLbl.Location = New System.Drawing.Point(25, 72)
        Me.projRevenueLbl.Name = "projRevenueLbl"
        Me.projRevenueLbl.Size = New System.Drawing.Size(114, 18)
        Me.projRevenueLbl.TabIndex = 1
        Me.projRevenueLbl.Text = "Project Revenue:"
        '
        'companyNameLbl
        '
        Me.companyNameLbl.AutoSize = True
        Me.companyNameLbl.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.companyNameLbl.Location = New System.Drawing.Point(25, 38)
        Me.companyNameLbl.Name = "companyNameLbl"
        Me.companyNameLbl.Size = New System.Drawing.Size(111, 18)
        Me.companyNameLbl.TabIndex = 0
        Me.companyNameLbl.Text = "Company Name: "
        '
        'projBox
        '
        Me.projBox.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projBox.FormattingEnabled = True
        Me.projBox.ItemHeight = 18
        Me.projBox.Location = New System.Drawing.Point(37, 53)
        Me.projBox.Name = "projBox"
        Me.projBox.Size = New System.Drawing.Size(204, 346)
        Me.projBox.TabIndex = 0
        '
        'officePic
        '
        Me.officePic.Image = Global.HW5.My.Resources.Resources.panorama
        Me.officePic.Location = New System.Drawing.Point(-1, -16)
        Me.officePic.Name = "officePic"
        Me.officePic.Size = New System.Drawing.Size(923, 244)
        Me.officePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.officePic.TabIndex = 6
        Me.officePic.TabStop = False
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 768)
        Me.Controls.Add(Me.officePic)
        Me.Controls.Add(Me.tabForm)
        Me.Controls.Add(Me.totalStaffingCostLblOutput)
        Me.Controls.Add(Me.totalStaffingCostLbl)
        Me.Controls.Add(Me.realBtn)
        Me.Controls.Add(Me.demoBtn)
        Me.Controls.Add(Me.optimizeBtn)
        Me.Name = "frmHome"
        Me.Text = "Staff Optimization Form"
        Me.tabForm.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.staffDetailsBox.ResumeLayout(False)
        Me.staffDetailsBox.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.projDetails.ResumeLayout(False)
        Me.projDetails.PerformLayout()
        CType(Me.officePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents optimizeBtn As Button
    Friend WithEvents demoBtn As RadioButton
    Friend WithEvents realBtn As RadioButton
    Friend WithEvents totalStaffingCostLbl As Label
    Friend WithEvents totalStaffingCostLblOutput As Label
    Friend WithEvents tabForm As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents weeklyHoursLbl As Label
    Friend WithEvents assignedProjLbl As Label
    Friend WithEvents assignedProjBox As ListBox
    Friend WithEvents workingHoursLbl As Label
    Friend WithEvents idleHoursLbl As Label
    Friend WithEvents baseRateLbl As Label
    Friend WithEvents classificationLbl As Label
    Friend WithEvents nameLbl As Label
    Friend WithEvents staffBox As ListBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents projDetails As GroupBox
    Friend WithEvents assignedStaffBox As ListBox
    Friend WithEvents assignedStaffLbl As Label
    Friend WithEvents profitMarginLbl As Label
    Friend WithEvents projCostLbl As Label
    Friend WithEvents industryLbl As Label
    Friend WithEvents projRevenueLbl As Label
    Friend WithEvents companyNameLbl As Label
    Friend WithEvents projBox As ListBox
    Friend WithEvents hoursTree As TreeView
    Friend WithEvents officePic As PictureBox
    Friend WithEvents staffDetailsBox As GroupBox
End Class
