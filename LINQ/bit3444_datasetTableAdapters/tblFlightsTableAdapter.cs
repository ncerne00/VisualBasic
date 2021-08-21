// Decompiled with JetBrains decompiler
// Type: LINQ.bit3444_datasetTableAdapters.tblFlightsTableAdapter
// Assembly: LINQ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ADC7924A-8176-4616-8423-22FB7B9F821F
// Assembly location: C:\Users\Nick\Downloads\LINQ.exe

using LINQ.My;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace LINQ.bit3444_datasetTableAdapters
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapter")]
  public class tblFlightsTableAdapter : Component
  {
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [field: AccessedThroughProperty("_adapter")]
    private virtual SqlDataAdapter _adapter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblFlightsTableAdapter() => this.ClearBeforeFill = true;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected internal SqlDataAdapter Adapter
    {
      get
      {
        if (this._adapter == null)
          this.InitAdapter();
        return this._adapter;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal SqlConnection Connection
    {
      get
      {
        if (this._connection == null)
          this.InitConnection();
        return this._connection;
      }
      set
      {
        this._connection = value;
        if (this.Adapter.InsertCommand != null)
          this.Adapter.InsertCommand.Connection = value;
        if (this.Adapter.DeleteCommand != null)
          this.Adapter.DeleteCommand.Connection = value;
        if (this.Adapter.UpdateCommand != null)
          this.Adapter.UpdateCommand.Connection = value;
        int index = 0;
        while (index < this.CommandCollection.Length)
        {
          if (this.CommandCollection[index] != null)
            this.CommandCollection[index].Connection = value;
          checked { ++index; }
        }
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal SqlTransaction Transaction
    {
      get => this._transaction;
      set
      {
        this._transaction = value;
        int index = 0;
        while (index < this.CommandCollection.Length)
        {
          this.CommandCollection[index].Transaction = this._transaction;
          checked { ++index; }
        }
        if (this.Adapter != null && this.Adapter.DeleteCommand != null)
          this.Adapter.DeleteCommand.Transaction = this._transaction;
        if (this.Adapter != null && this.Adapter.InsertCommand != null)
          this.Adapter.InsertCommand.Transaction = this._transaction;
        if (this.Adapter == null || this.Adapter.UpdateCommand == null)
          return;
        this.Adapter.UpdateCommand.Transaction = this._transaction;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected SqlCommand[] CommandCollection
    {
      get
      {
        if (this._commandCollection == null)
          this.InitCommandCollection();
        return this._commandCollection;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool ClearBeforeFill
    {
      get => this._clearBeforeFill;
      set => this._clearBeforeFill = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitAdapter()
    {
      this._adapter = new SqlDataAdapter();
      this._adapter.TableMappings.Add((object) new DataTableMapping()
      {
        SourceTable = "Table",
        DataSetTable = "tblFlights",
        ColumnMappings = {
          {
            "flightID",
            "flightID"
          },
          {
            "departFROM",
            "departFROM"
          },
          {
            "arriveAT",
            "arriveAT"
          },
          {
            "distance",
            "distance"
          },
          {
            "active",
            "active"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [bit3444_hw3].[tblFlights] WHERE (([flightID] = @Original_flightID) AND ([departFROM] = @Original_departFROM) AND ([arriveAT] = @Original_arriveAT) AND ([distance] = @Original_distance) AND ([active] = @Original_active))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_flightID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "flightID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_departFROM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "departFROM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_arriveAT", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "arriveAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_distance", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 0, "distance", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_active", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "active", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [bit3444_hw3].[tblFlights] ([departFROM], [arriveAT], [distance], [active]) VALUES (@departFROM, @arriveAT, @distance, @active);\r\nSELECT flightID, departFROM, arriveAT, distance, active FROM tblFlights WHERE (flightID = SCOPE_IDENTITY())";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@departFROM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "departFROM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@arriveAT", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "arriveAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@distance", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 0, "distance", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@active", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "active", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [bit3444_hw3].[tblFlights] SET [departFROM] = @departFROM, [arriveAT] = @arriveAT, [distance] = @distance, [active] = @active WHERE (([flightID] = @Original_flightID) AND ([departFROM] = @Original_departFROM) AND ([arriveAT] = @Original_arriveAT) AND ([distance] = @Original_distance) AND ([active] = @Original_active));\r\nSELECT flightID, departFROM, arriveAT, distance, active FROM tblFlights WHERE (flightID = @flightID)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@departFROM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "departFROM", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@arriveAT", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "arriveAT", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@distance", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 0, "distance", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@active", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "active", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_flightID", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "flightID", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_departFROM", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "departFROM", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_arriveAT", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "arriveAT", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_distance", SqlDbType.Decimal, 0, ParameterDirection.Input, (byte) 18, (byte) 0, "distance", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_active", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "active", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@flightID", SqlDbType.Int, 4, ParameterDirection.Input, (byte) 0, (byte) 0, "flightID", DataRowVersion.Current, false, (object) null, "", "", ""));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitConnection()
    {
      this._connection = new SqlConnection();
      this._connection.ConnectionString = MySettings.Default.bit3444_hw3;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitCommandCollection()
    {
      this._commandCollection = new SqlCommand[1];
      this._commandCollection[0] = new SqlCommand();
      this._commandCollection[0].Connection = this.Connection;
      this._commandCollection[0].CommandText = "SELECT flightID, departFROM, arriveAT, distance, active FROM bit3444_hw3.tblFlights";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(bit3444_dataset.tblFlightsDataTable dataTable)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return this.Adapter.Fill((DataTable) dataTable);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public virtual bit3444_dataset.tblFlightsDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      bit3444_dataset.tblFlightsDataTable flightsDataTable = new bit3444_dataset.tblFlightsDataTable();
      this.Adapter.Fill((DataTable) flightsDataTable);
      return flightsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bit3444_dataset.tblFlightsDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bit3444_dataset dataSet) => this.Adapter.Update((DataSet) dataSet, "tblFlights");

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(DataRow dataRow) => this.Adapter.Update(new DataRow[1]
    {
      dataRow
    });

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(DataRow[] dataRows) => this.Adapter.Update(dataRows);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Delete, true)]
    public virtual int Delete(
      int Original_flightID,
      string Original_departFROM,
      string Original_arriveAT,
      Decimal Original_distance,
      bool Original_active)
    {
      this.Adapter.DeleteCommand.Parameters[0].Value = (object) Original_flightID;
      this.Adapter.DeleteCommand.Parameters[1].Value = Original_departFROM != null ? (object) Original_departFROM : throw new ArgumentNullException(nameof (Original_departFROM));
      this.Adapter.DeleteCommand.Parameters[2].Value = Original_arriveAT != null ? (object) Original_arriveAT : throw new ArgumentNullException(nameof (Original_arriveAT));
      this.Adapter.DeleteCommand.Parameters[3].Value = (object) Original_distance;
      this.Adapter.DeleteCommand.Parameters[4].Value = (object) Original_active;
      ConnectionState state = this.Adapter.DeleteCommand.Connection.State;
      if ((this.Adapter.DeleteCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        this.Adapter.DeleteCommand.Connection.Open();
      try
      {
        return this.Adapter.DeleteCommand.ExecuteNonQuery();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          this.Adapter.DeleteCommand.Connection.Close();
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Insert, true)]
    public virtual int Insert(string departFROM, string arriveAT, Decimal distance, bool active)
    {
      this.Adapter.InsertCommand.Parameters[0].Value = departFROM != null ? (object) departFROM : throw new ArgumentNullException(nameof (departFROM));
      this.Adapter.InsertCommand.Parameters[1].Value = arriveAT != null ? (object) arriveAT : throw new ArgumentNullException(nameof (arriveAT));
      this.Adapter.InsertCommand.Parameters[2].Value = (object) distance;
      this.Adapter.InsertCommand.Parameters[3].Value = (object) active;
      ConnectionState state = this.Adapter.InsertCommand.Connection.State;
      if ((this.Adapter.InsertCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        this.Adapter.InsertCommand.Connection.Open();
      try
      {
        return this.Adapter.InsertCommand.ExecuteNonQuery();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          this.Adapter.InsertCommand.Connection.Close();
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Update, true)]
    public virtual int Update(
      string departFROM,
      string arriveAT,
      Decimal distance,
      bool active,
      int Original_flightID,
      string Original_departFROM,
      string Original_arriveAT,
      Decimal Original_distance,
      bool Original_active,
      int flightID)
    {
      this.Adapter.UpdateCommand.Parameters[0].Value = departFROM != null ? (object) departFROM : throw new ArgumentNullException(nameof (departFROM));
      this.Adapter.UpdateCommand.Parameters[1].Value = arriveAT != null ? (object) arriveAT : throw new ArgumentNullException(nameof (arriveAT));
      this.Adapter.UpdateCommand.Parameters[2].Value = (object) distance;
      this.Adapter.UpdateCommand.Parameters[3].Value = (object) active;
      this.Adapter.UpdateCommand.Parameters[4].Value = (object) Original_flightID;
      this.Adapter.UpdateCommand.Parameters[5].Value = Original_departFROM != null ? (object) Original_departFROM : throw new ArgumentNullException(nameof (Original_departFROM));
      this.Adapter.UpdateCommand.Parameters[6].Value = Original_arriveAT != null ? (object) Original_arriveAT : throw new ArgumentNullException(nameof (Original_arriveAT));
      this.Adapter.UpdateCommand.Parameters[7].Value = (object) Original_distance;
      this.Adapter.UpdateCommand.Parameters[8].Value = (object) Original_active;
      this.Adapter.UpdateCommand.Parameters[9].Value = (object) flightID;
      ConnectionState state = this.Adapter.UpdateCommand.Connection.State;
      if ((this.Adapter.UpdateCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        this.Adapter.UpdateCommand.Connection.Open();
      try
      {
        return this.Adapter.UpdateCommand.ExecuteNonQuery();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          this.Adapter.UpdateCommand.Connection.Close();
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Update, true)]
    public virtual int Update(
      string departFROM,
      string arriveAT,
      Decimal distance,
      bool active,
      int Original_flightID,
      string Original_departFROM,
      string Original_arriveAT,
      Decimal Original_distance,
      bool Original_active)
    {
      return this.Update(departFROM, arriveAT, distance, active, Original_flightID, Original_departFROM, Original_arriveAT, Original_distance, Original_active, Original_flightID);
    }
  }
}
