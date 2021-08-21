<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLINQ
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
        Me.btnLINQExample1 = New System.Windows.Forms.Button()
        Me.btnLINQExample2 = New System.Windows.Forms.Button()
        Me.lstReturn = New System.Windows.Forms.ListBox()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnLINQExample1
        '
        Me.btnLINQExample1.Location = New System.Drawing.Point(30, 34)
        Me.btnLINQExample1.Name = "btnLINQExample1"
        Me.btnLINQExample1.Size = New System.Drawing.Size(150, 54)
        Me.btnLINQExample1.TabIndex = 0
        Me.btnLINQExample1.Text = "Get New York Airports"
        Me.btnLINQExample1.UseVisualStyleBackColor = True
        '
        'btnLINQExample2
        '
        Me.btnLINQExample2.Location = New System.Drawing.Point(218, 34)
        Me.btnLINQExample2.Name = "btnLINQExample2"
        Me.btnLINQExample2.Size = New System.Drawing.Size(148, 54)
        Me.btnLINQExample2.TabIndex = 1
        Me.btnLINQExample2.Text = "Get Flights Longer than"
        Me.btnLINQExample2.UseVisualStyleBackColor = True
        '
        'lstReturn
        '
        Me.lstReturn.FormattingEnabled = True
        Me.lstReturn.Location = New System.Drawing.Point(30, 182)
        Me.lstReturn.Name = "lstReturn"
        Me.lstReturn.Size = New System.Drawing.Size(336, 277)
        Me.lstReturn.TabIndex = 2
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(218, 95)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(148, 20)
        Me.txtMiles.TabIndex = 3
        '
        'frmLINQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 502)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.lstReturn)
        Me.Controls.Add(Me.btnLINQExample2)
        Me.Controls.Add(Me.btnLINQExample1)
        Me.Name = "frmLINQ"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLINQExample1 As Button
    Friend WithEvents btnLINQExample2 As Button
    Friend WithEvents lstReturn As ListBox
    Friend WithEvents txtMiles As TextBox
End Class
