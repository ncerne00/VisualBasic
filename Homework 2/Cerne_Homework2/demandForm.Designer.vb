<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class demandFrm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.productBox = New System.Windows.Forms.TextBox()
        Me.yearBox = New System.Windows.Forms.TextBox()
        Me.showDemandBtn = New System.Windows.Forms.Button()
        Me.showAllDemandBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Year"
        '
        'productBox
        '
        Me.productBox.Location = New System.Drawing.Point(86, 31)
        Me.productBox.Name = "productBox"
        Me.productBox.Size = New System.Drawing.Size(100, 20)
        Me.productBox.TabIndex = 2
        '
        'yearBox
        '
        Me.yearBox.Location = New System.Drawing.Point(86, 62)
        Me.yearBox.Name = "yearBox"
        Me.yearBox.Size = New System.Drawing.Size(100, 20)
        Me.yearBox.TabIndex = 3
        '
        'showDemandBtn
        '
        Me.showDemandBtn.Location = New System.Drawing.Point(86, 88)
        Me.showDemandBtn.Name = "showDemandBtn"
        Me.showDemandBtn.Size = New System.Drawing.Size(100, 23)
        Me.showDemandBtn.TabIndex = 4
        Me.showDemandBtn.Text = "Show Demand"
        Me.showDemandBtn.UseVisualStyleBackColor = True
        '
        'showAllDemandBtn
        '
        Me.showAllDemandBtn.Location = New System.Drawing.Point(86, 117)
        Me.showAllDemandBtn.Name = "showAllDemandBtn"
        Me.showAllDemandBtn.Size = New System.Drawing.Size(100, 23)
        Me.showAllDemandBtn.TabIndex = 5
        Me.showAllDemandBtn.Text = "Show All Demand"
        Me.showAllDemandBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(86, 146)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(100, 23)
        Me.exitBtn.TabIndex = 6
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'demandFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 195)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.showAllDemandBtn)
        Me.Controls.Add(Me.showDemandBtn)
        Me.Controls.Add(Me.yearBox)
        Me.Controls.Add(Me.productBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "demandFrm"
        Me.Text = "Demand"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents productBox As TextBox
    Friend WithEvents yearBox As TextBox
    Friend WithEvents showDemandBtn As Button
    Friend WithEvents showAllDemandBtn As Button
    Friend WithEvents exitBtn As Button
End Class
