<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAssignment
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
        Me.mechBox = New System.Windows.Forms.ListBox()
        Me.brdBox = New System.Windows.Forms.ListBox()
        Me.mechLbl = New System.Windows.Forms.Label()
        Me.brdLbl = New System.Windows.Forms.Label()
        Me.assignmentBtn = New System.Windows.Forms.Button()
        Me.expertiseLbl = New System.Windows.Forms.Label()
        Me.expertiseLblOutput = New System.Windows.Forms.Label()
        Me.specificExpertiseLbl = New System.Windows.Forms.Label()
        Me.rickyBobbyPic = New System.Windows.Forms.PictureBox()
        Me.bobbyLbl = New System.Windows.Forms.Label()
        CType(Me.rickyBobbyPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mechBox
        '
        Me.mechBox.FormattingEnabled = True
        Me.mechBox.Location = New System.Drawing.Point(12, 40)
        Me.mechBox.Name = "mechBox"
        Me.mechBox.Size = New System.Drawing.Size(202, 264)
        Me.mechBox.TabIndex = 0
        '
        'brdBox
        '
        Me.brdBox.FormattingEnabled = True
        Me.brdBox.Location = New System.Drawing.Point(234, 40)
        Me.brdBox.Name = "brdBox"
        Me.brdBox.Size = New System.Drawing.Size(195, 264)
        Me.brdBox.TabIndex = 1
        '
        'mechLbl
        '
        Me.mechLbl.AutoSize = True
        Me.mechLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mechLbl.Location = New System.Drawing.Point(52, 13)
        Me.mechLbl.Name = "mechLbl"
        Me.mechLbl.Size = New System.Drawing.Size(101, 24)
        Me.mechLbl.TabIndex = 2
        Me.mechLbl.Text = "Mechanic"
        '
        'brdLbl
        '
        Me.brdLbl.AutoSize = True
        Me.brdLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brdLbl.Location = New System.Drawing.Point(299, 13)
        Me.brdLbl.Name = "brdLbl"
        Me.brdLbl.Size = New System.Drawing.Size(65, 24)
        Me.brdLbl.TabIndex = 3
        Me.brdLbl.Text = "Brand"
        '
        'assignmentBtn
        '
        Me.assignmentBtn.Location = New System.Drawing.Point(12, 352)
        Me.assignmentBtn.Name = "assignmentBtn"
        Me.assignmentBtn.Size = New System.Drawing.Size(173, 54)
        Me.assignmentBtn.TabIndex = 4
        Me.assignmentBtn.Text = "Create Assignments"
        Me.assignmentBtn.UseVisualStyleBackColor = True
        '
        'expertiseLbl
        '
        Me.expertiseLbl.AutoSize = True
        Me.expertiseLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expertiseLbl.Location = New System.Drawing.Point(248, 365)
        Me.expertiseLbl.Name = "expertiseLbl"
        Me.expertiseLbl.Size = New System.Drawing.Size(156, 24)
        Me.expertiseLbl.TabIndex = 5
        Me.expertiseLbl.Text = "Total Expertise:"
        '
        'expertiseLblOutput
        '
        Me.expertiseLblOutput.AutoSize = True
        Me.expertiseLblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expertiseLblOutput.Location = New System.Drawing.Point(422, 365)
        Me.expertiseLblOutput.Name = "expertiseLblOutput"
        Me.expertiseLblOutput.Size = New System.Drawing.Size(21, 24)
        Me.expertiseLblOutput.TabIndex = 6
        Me.expertiseLblOutput.Text = "0"
        '
        'specificExpertiseLbl
        '
        Me.specificExpertiseLbl.AutoSize = True
        Me.specificExpertiseLbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specificExpertiseLbl.Location = New System.Drawing.Point(248, 409)
        Me.specificExpertiseLbl.Name = "specificExpertiseLbl"
        Me.specificExpertiseLbl.Size = New System.Drawing.Size(118, 22)
        Me.specificExpertiseLbl.TabIndex = 7
        Me.specificExpertiseLbl.Text = "placeholder"
        '
        'rickyBobbyPic
        '
        Me.rickyBobbyPic.Image = Global.Homework4.My.Resources.Resources.talladega
        Me.rickyBobbyPic.Location = New System.Drawing.Point(470, 40)
        Me.rickyBobbyPic.Name = "rickyBobbyPic"
        Me.rickyBobbyPic.Size = New System.Drawing.Size(308, 264)
        Me.rickyBobbyPic.TabIndex = 8
        Me.rickyBobbyPic.TabStop = False
        '
        'bobbyLbl
        '
        Me.bobbyLbl.AutoSize = True
        Me.bobbyLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bobbyLbl.Location = New System.Drawing.Point(418, 307)
        Me.bobbyLbl.Name = "bobbyLbl"
        Me.bobbyLbl.Size = New System.Drawing.Size(405, 24)
        Me.bobbyLbl.TabIndex = 9
        Me.bobbyLbl.Text = """If you ain't first, you're last."" - Ricky Bobby"
        '
        'frmAssignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 499)
        Me.Controls.Add(Me.bobbyLbl)
        Me.Controls.Add(Me.rickyBobbyPic)
        Me.Controls.Add(Me.specificExpertiseLbl)
        Me.Controls.Add(Me.expertiseLblOutput)
        Me.Controls.Add(Me.expertiseLbl)
        Me.Controls.Add(Me.assignmentBtn)
        Me.Controls.Add(Me.brdLbl)
        Me.Controls.Add(Me.mechLbl)
        Me.Controls.Add(Me.brdBox)
        Me.Controls.Add(Me.mechBox)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmAssignment"
        Me.Text = "Talladega Mechanic Shop"
        CType(Me.rickyBobbyPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mechBox As ListBox
    Friend WithEvents brdBox As ListBox
    Friend WithEvents mechLbl As Label
    Friend WithEvents brdLbl As Label
    Friend WithEvents assignmentBtn As Button
    Friend WithEvents expertiseLbl As Label
    Friend WithEvents expertiseLblOutput As Label
    Friend WithEvents specificExpertiseLbl As Label
    Friend WithEvents rickyBobbyPic As PictureBox
    Friend WithEvents bobbyLbl As Label
End Class
