// Decompiled with JetBrains decompiler
// Type: LINQ.frmAirports
// Assembly: LINQ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ADC7924A-8176-4616-8423-22FB7B9F821F
// Assembly location: C:\Users\Nick\Downloads\LINQ.exe

using LINQ.bit3444_datasetTableAdapters;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace LINQ
{
  [DesignerGenerated]
  public class frmAirports : Form
  {
    private IContainer components;

    public frmAirports()
    {
      this.Load += new EventHandler(this.frmAirports_Load);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
      this.dgAirports = new DataGridView();
      this.btnGetFlights = new Button();
      this.btnSave = new Button();
      this.DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
      this.DataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
      this.DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
      this.DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
      this.TblAirportsBindingSource = new BindingSource(this.components);
      this.Bit3444_dataset = new bit3444_dataset();
      this.TblAirportsTableAdapter = new tblAirportsTableAdapter();
      this.TableAdapterManager = new TableAdapterManager();
      ((ISupportInitialize) this.dgAirports).BeginInit();
      ((ISupportInitialize) this.TblAirportsBindingSource).BeginInit();
      this.Bit3444_dataset.BeginInit();
      this.SuspendLayout();
      gridViewCellStyle.BackColor = Color.FromArgb(224, 224, 224);
      this.dgAirports.AlternatingRowsDefaultCellStyle = gridViewCellStyle;
      this.dgAirports.AutoGenerateColumns = false;
      this.dgAirports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgAirports.Columns.AddRange((DataGridViewColumn) this.DataGridViewTextBoxColumn1, (DataGridViewColumn) this.DataGridViewTextBoxColumn2, (DataGridViewColumn) this.DataGridViewTextBoxColumn4, (DataGridViewColumn) this.DataGridViewCheckBoxColumn1, (DataGridViewColumn) this.DataGridViewTextBoxColumn5, (DataGridViewColumn) this.DataGridViewTextBoxColumn6);
      this.dgAirports.DataSource = (object) this.TblAirportsBindingSource;
      this.dgAirports.Location = new Point(12, 22);
      this.dgAirports.Name = "dgAirports";
      this.dgAirports.Size = new Size(652, 513);
      this.dgAirports.TabIndex = 1;
      this.btnGetFlights.Location = new Point(21, 570);
      this.btnGetFlights.Name = "btnGetFlights";
      this.btnGetFlights.Size = new Size(171, 47);
      this.btnGetFlights.TabIndex = 2;
      this.btnGetFlights.Text = "Show Active Flights";
      this.btnGetFlights.UseVisualStyleBackColor = true;
      this.btnSave.Location = new Point(493, 570);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(171, 47);
      this.btnSave.TabIndex = 3;
      this.btnSave.Text = "Save Changes";
      this.btnSave.UseVisualStyleBackColor = true;
      this.DataGridViewTextBoxColumn1.DataPropertyName = "Code";
      this.DataGridViewTextBoxColumn1.HeaderText = "Code";
      this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
      this.DataGridViewTextBoxColumn1.ReadOnly = true;
      this.DataGridViewTextBoxColumn2.DataPropertyName = "City";
      this.DataGridViewTextBoxColumn2.HeaderText = "City";
      this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
      this.DataGridViewTextBoxColumn2.ReadOnly = true;
      this.DataGridViewTextBoxColumn4.DataPropertyName = "Name";
      this.DataGridViewTextBoxColumn4.HeaderText = "Name";
      this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
      this.DataGridViewTextBoxColumn4.ReadOnly = true;
      this.DataGridViewCheckBoxColumn1.DataPropertyName = "Active";
      this.DataGridViewCheckBoxColumn1.HeaderText = "Active";
      this.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1";
      this.DataGridViewTextBoxColumn5.DataPropertyName = "Lat";
      this.DataGridViewTextBoxColumn5.HeaderText = "Lat";
      this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
      this.DataGridViewTextBoxColumn5.ReadOnly = true;
      this.DataGridViewTextBoxColumn6.DataPropertyName = "Long";
      this.DataGridViewTextBoxColumn6.HeaderText = "Long";
      this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
      this.DataGridViewTextBoxColumn6.ReadOnly = true;
      this.TblAirportsBindingSource.DataMember = "tblAirports";
      this.TblAirportsBindingSource.DataSource = (object) this.Bit3444_dataset;
      this.Bit3444_dataset.DataSetName = "bit3444_dataset";
      this.Bit3444_dataset.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.TblAirportsTableAdapter.ClearBeforeFill = true;
      this.TableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.TableAdapterManager.tblAirportsTableAdapter = this.TblAirportsTableAdapter;
      this.TableAdapterManager.tblFlightsTableAdapter = (tblFlightsTableAdapter) null;
      this.TableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(676, 635);
      this.Controls.Add((Control) this.btnSave);
      this.Controls.Add((Control) this.btnGetFlights);
      this.Controls.Add((Control) this.dgAirports);
      this.Name = nameof (frmAirports);
      this.Text = "U.S. Airports";
      ((ISupportInitialize) this.dgAirports).EndInit();
      ((ISupportInitialize) this.TblAirportsBindingSource).EndInit();
      this.Bit3444_dataset.EndInit();
      this.ResumeLayout(false);
    }

    [field: AccessedThroughProperty("Bit3444_dataset")]
    internal virtual bit3444_dataset Bit3444_dataset { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TblAirportsBindingSource")]
    internal virtual BindingSource TblAirportsBindingSource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TblAirportsTableAdapter")]
    internal virtual tblAirportsTableAdapter TblAirportsTableAdapter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("TableAdapterManager")]
    internal virtual TableAdapterManager TableAdapterManager { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("dgAirports")]
    internal virtual DataGridView dgAirports { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn1")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn2")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn4")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewCheckBoxColumn1")]
    internal virtual DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn5")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("DataGridViewTextBoxColumn6")]
    internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnGetFlights
    {
      get => this._btnGetFlights;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnGetFlights_Click);
        Button btnGetFlights1 = this._btnGetFlights;
        if (btnGetFlights1 != null)
          btnGetFlights1.Click -= eventHandler;
        this._btnGetFlights = value;
        Button btnGetFlights2 = this._btnGetFlights;
        if (btnGetFlights2 == null)
          return;
        btnGetFlights2.Click += eventHandler;
      }
    }

    internal virtual Button btnSave
    {
      get => this._btnSave;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnSave_Click);
        Button btnSave1 = this._btnSave;
        if (btnSave1 != null)
          btnSave1.Click -= eventHandler;
        this._btnSave = value;
        Button btnSave2 = this._btnSave;
        if (btnSave2 == null)
          return;
        btnSave2.Click += eventHandler;
      }
    }

    private void frmAirports_Load(object sender, EventArgs e) => this.TblAirportsTableAdapter.Fill(this.Bit3444_dataset.tblAirports);

    private void btnGetFlights_Click(object sender, EventArgs e) => new frmFlight(Conversions.ToString(this.dgAirports.CurrentRow.Cells[0].Value)).Show();

    private void btnSave_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.TblAirportsBindingSource.EndEdit();
      this.TableAdapterManager.UpdateAll(this.Bit3444_dataset);
    }
  }
}
