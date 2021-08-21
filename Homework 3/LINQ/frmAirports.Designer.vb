<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAirports
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgAirports = New System.Windows.Forms.DataGridView()
        Me.TblAirportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bit3444_dataset = New LINQ.bit3444_dataset()
        Me.btnGetFlights = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TblAirportsTableAdapter = New LINQ.bit3444_datasetTableAdapters.tblAirportsTableAdapter()
        Me.TableAdapterManager = New LINQ.bit3444_datasetTableAdapters.TableAdapterManager()
        CType(Me.dgAirports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAirportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bit3444_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgAirports
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgAirports.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgAirports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAirports.Location = New System.Drawing.Point(12, 22)
        Me.dgAirports.Name = "dgAirports"
        Me.dgAirports.Size = New System.Drawing.Size(652, 513)
        Me.dgAirports.TabIndex = 1
        '
        'TblAirportsBindingSource
        '
        Me.TblAirportsBindingSource.DataMember = "tblAirports"
        Me.TblAirportsBindingSource.DataSource = Me.Bit3444_dataset
        '
        'Bit3444_dataset
        '
        Me.Bit3444_dataset.DataSetName = "bit3444_dataset"
        Me.Bit3444_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnGetFlights
        '
        Me.btnGetFlights.Location = New System.Drawing.Point(21, 570)
        Me.btnGetFlights.Name = "btnGetFlights"
        Me.btnGetFlights.Size = New System.Drawing.Size(171, 47)
        Me.btnGetFlights.TabIndex = 2
        Me.btnGetFlights.Text = "Show Active Flights"
        Me.btnGetFlights.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(493, 570)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(171, 47)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'TblAirportsTableAdapter
        '
        Me.TblAirportsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAirportsTableAdapter = Me.TblAirportsTableAdapter
        Me.TableAdapterManager.tblFlightsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LINQ.bit3444_datasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmAirports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 635)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnGetFlights)
        Me.Controls.Add(Me.dgAirports)
        Me.Name = "frmAirports"
        Me.Text = "U.S. Airports"
        CType(Me.dgAirports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAirportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bit3444_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Bit3444_dataset As bit3444_dataset
    Friend WithEvents TblAirportsBindingSource As BindingSource
    Friend WithEvents TblAirportsTableAdapter As bit3444_datasetTableAdapters.tblAirportsTableAdapter
    Friend WithEvents TableAdapterManager As bit3444_datasetTableAdapters.TableAdapterManager
    Friend WithEvents dgAirports As DataGridView
    Friend WithEvents btnGetFlights As Button
    Friend WithEvents btnSave As Button
End Class
