<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNetwork
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
        Me.btnShortestPath = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboOrigin = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboDestination = New System.Windows.Forms.ComboBox()
        Me.lstPath = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cboRadius = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnShortestPath
        '
        Me.btnShortestPath.Location = New System.Drawing.Point(24, 287)
        Me.btnShortestPath.Margin = New System.Windows.Forms.Padding(2)
        Me.btnShortestPath.Name = "btnShortestPath"
        Me.btnShortestPath.Size = New System.Drawing.Size(88, 37)
        Me.btnShortestPath.TabIndex = 9
        Me.btnShortestPath.Text = "Shortest Path"
        Me.btnShortestPath.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Origin"
        '
        'cboOrigin
        '
        Me.cboOrigin.FormattingEnabled = True
        Me.cboOrigin.Location = New System.Drawing.Point(24, 60)
        Me.cboOrigin.Name = "cboOrigin"
        Me.cboOrigin.Size = New System.Drawing.Size(122, 21)
        Me.cboOrigin.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(163, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Destination"
        '
        'cboDestination
        '
        Me.cboDestination.FormattingEnabled = True
        Me.cboDestination.Location = New System.Drawing.Point(166, 60)
        Me.cboDestination.Name = "cboDestination"
        Me.cboDestination.Size = New System.Drawing.Size(122, 21)
        Me.cboDestination.TabIndex = 4
        '
        'lstPath
        '
        Me.lstPath.FormattingEnabled = True
        Me.lstPath.Location = New System.Drawing.Point(24, 136)
        Me.lstPath.Name = "lstPath"
        Me.lstPath.Size = New System.Drawing.Size(406, 121)
        Me.lstPath.TabIndex = 8
        Me.lstPath.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Shortest Path"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(342, 287)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 37)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cboRadius
        '
        Me.cboRadius.FormattingEnabled = True
        Me.cboRadius.Location = New System.Drawing.Point(308, 60)
        Me.cboRadius.Name = "cboRadius"
        Me.cboRadius.Size = New System.Drawing.Size(122, 21)
        Me.cboRadius.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(305, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Radius"
        '
        'frmNetwork
        '
        Me.AcceptButton = Me.btnShortestPath
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(459, 351)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboRadius)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstPath)
        Me.Controls.Add(Me.cboDestination)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboOrigin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnShortestPath)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmNetwork"
        Me.Text = "Network"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShortestPath As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboOrigin As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboDestination As ComboBox
    Friend WithEvents lstPath As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents cboRadius As ComboBox
    Friend WithEvents Label3 As Label
End Class
