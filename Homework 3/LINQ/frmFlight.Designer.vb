<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFlight
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.listFlightsBox = New System.Windows.Forms.ListBox()
        Me.originLbl = New System.Windows.Forms.Label()
        Me.dptFrmLbl = New System.Windows.Forms.Label()
        Me.arrLbl = New System.Windows.Forms.Label()
        Me.distanceLbl = New System.Windows.Forms.Label()
        Me.dptLbl2 = New System.Windows.Forms.Label()
        Me.arrLbl2 = New System.Windows.Forms.Label()
        Me.distLbl2 = New System.Windows.Forms.Label()
        Me.departLabel = New System.Windows.Forms.Label()
        Me.arriveLabel = New System.Windows.Forms.Label()
        Me.distanceLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(458, 238)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(103, 30)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'listFlightsBox
        '
        Me.listFlightsBox.FormattingEnabled = True
        Me.listFlightsBox.Location = New System.Drawing.Point(12, 56)
        Me.listFlightsBox.Name = "listFlightsBox"
        Me.listFlightsBox.Size = New System.Drawing.Size(172, 186)
        Me.listFlightsBox.TabIndex = 9
        '
        'originLbl
        '
        Me.originLbl.AutoSize = True
        Me.originLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.originLbl.Location = New System.Drawing.Point(22, 23)
        Me.originLbl.Name = "originLbl"
        Me.originLbl.Size = New System.Drawing.Size(0, 25)
        Me.originLbl.TabIndex = 10
        '
        'dptFrmLbl
        '
        Me.dptFrmLbl.AutoSize = True
        Me.dptFrmLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptFrmLbl.Location = New System.Drawing.Point(210, 56)
        Me.dptFrmLbl.Name = "dptFrmLbl"
        Me.dptFrmLbl.Size = New System.Drawing.Size(115, 24)
        Me.dptFrmLbl.TabIndex = 11
        Me.dptFrmLbl.Text = "Depart From"
        '
        'arrLbl
        '
        Me.arrLbl.AutoSize = True
        Me.arrLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arrLbl.Location = New System.Drawing.Point(210, 102)
        Me.arrLbl.Name = "arrLbl"
        Me.arrLbl.Size = New System.Drawing.Size(81, 24)
        Me.arrLbl.TabIndex = 12
        Me.arrLbl.Text = "Arrive At"
        '
        'distanceLbl
        '
        Me.distanceLbl.AutoSize = True
        Me.distanceLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.distanceLbl.Location = New System.Drawing.Point(210, 141)
        Me.distanceLbl.Name = "distanceLbl"
        Me.distanceLbl.Size = New System.Drawing.Size(82, 24)
        Me.distanceLbl.TabIndex = 13
        Me.distanceLbl.Text = "Distance"
        '
        'dptLbl2
        '
        Me.dptLbl2.AutoSize = True
        Me.dptLbl2.Location = New System.Drawing.Point(364, 66)
        Me.dptLbl2.Name = "dptLbl2"
        Me.dptLbl2.Size = New System.Drawing.Size(0, 13)
        Me.dptLbl2.TabIndex = 14
        '
        'arrLbl2
        '
        Me.arrLbl2.AutoSize = True
        Me.arrLbl2.Location = New System.Drawing.Point(364, 110)
        Me.arrLbl2.Name = "arrLbl2"
        Me.arrLbl2.Size = New System.Drawing.Size(0, 13)
        Me.arrLbl2.TabIndex = 15
        '
        'distLbl2
        '
        Me.distLbl2.AutoSize = True
        Me.distLbl2.Location = New System.Drawing.Point(364, 152)
        Me.distLbl2.Name = "distLbl2"
        Me.distLbl2.Size = New System.Drawing.Size(0, 13)
        Me.distLbl2.TabIndex = 16
        '
        'departLabel
        '
        Me.departLabel.AutoSize = True
        Me.departLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departLabel.Location = New System.Drawing.Point(348, 59)
        Me.departLabel.Name = "departLabel"
        Me.departLabel.Size = New System.Drawing.Size(0, 20)
        Me.departLabel.TabIndex = 17
        '
        'arriveLabel
        '
        Me.arriveLabel.AutoSize = True
        Me.arriveLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arriveLabel.Location = New System.Drawing.Point(348, 106)
        Me.arriveLabel.Name = "arriveLabel"
        Me.arriveLabel.Size = New System.Drawing.Size(0, 20)
        Me.arriveLabel.TabIndex = 18
        '
        'distanceLabel
        '
        Me.distanceLabel.AutoSize = True
        Me.distanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.distanceLabel.Location = New System.Drawing.Point(348, 152)
        Me.distanceLabel.Name = "distanceLabel"
        Me.distanceLabel.Size = New System.Drawing.Size(0, 20)
        Me.distanceLabel.TabIndex = 19
        '
        'frmFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 280)
        Me.Controls.Add(Me.distanceLabel)
        Me.Controls.Add(Me.arriveLabel)
        Me.Controls.Add(Me.departLabel)
        Me.Controls.Add(Me.distLbl2)
        Me.Controls.Add(Me.arrLbl2)
        Me.Controls.Add(Me.dptLbl2)
        Me.Controls.Add(Me.distanceLbl)
        Me.Controls.Add(Me.arrLbl)
        Me.Controls.Add(Me.dptFrmLbl)
        Me.Controls.Add(Me.originLbl)
        Me.Controls.Add(Me.listFlightsBox)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmFlight"
        Me.Text = "Flights Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As Button
    Friend WithEvents listFlightsBox As ListBox
    Friend WithEvents originLbl As Label
    Friend WithEvents dptFrmLbl As Label
    Friend WithEvents arrLbl As Label
    Friend WithEvents distanceLbl As Label
    Friend WithEvents dptLbl2 As Label
    Friend WithEvents arrLbl2 As Label
    Friend WithEvents distLbl2 As Label
    Friend WithEvents departLabel As Label
    Friend WithEvents arriveLabel As Label
    Friend WithEvents distanceLabel As Label
End Class
