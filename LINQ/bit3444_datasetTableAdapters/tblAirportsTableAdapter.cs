// Decompiled with JetBrains decompiler
// Type: LINQ.bit3444_datasetTableAdapters.tblAirportsTableAdapter
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
  public class tblAirportsTableAdapter : Component
  {
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [field: AccessedThroughProperty("_adapter")]
    private virtual SqlDataAdapter _adapter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public tblAirportsTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "tblAirports",
        ColumnMappings = {
          {
            "Code",
            "Code"
          },
          {
            "City",
            "City"
          },
          {
            "State",
            "State"
          },
          {
            "Name",
            "Name"
          },
          {
            "Active",
            "Active"
          },
          {
            "Lat",
            "Lat"
          },
          {
            "Long",
            "Long"
          }
        }
      });
      this._adapter.DeleteCommand = new SqlCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM [bit3444_hw3].[tblAirports] WHERE (([Code] = @Original_Code) AND ([City] = @Original_City) AND ((@IsNull_State = 1 AND [State] IS NULL) OR ([State] = @Original_State)) AND ([Name] = @Original_Name) AND ((@IsNull_Active = 1 AND [Active] IS NULL) OR ([Active] = @Original_Active)) AND ((@IsNull_Lat = 1 AND [Lat] IS NULL) OR ([Lat] = @Original_Lat)) AND ((@IsNull_Long = 1 AND [Long] IS NULL) OR ([Long] = @Original_Long)))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Code", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Code", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_City", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "City", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_State", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "State", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_State", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "State", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Name", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Name", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Active", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Active", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Active", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Active", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Lat", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Lat", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Lat", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Lat", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Long", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Long", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Long", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Long", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.InsertCommand = new SqlCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO [bit3444_hw3].[tblAirports] ([Code], [City], [State], [Name], [Active], [Lat], [Long]) VALUES (@Code, @City, @State, @Name, @Active, @Lat, @Long);\r\nSELECT Code, City, State, Name, Active, Lat, Long FROM tblAirports WHERE (Code = @Code)";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Code", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Code", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@City", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "City", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@State", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "State", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Name", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Active", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Active", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Lat", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Lat", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Long", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Long", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand = new SqlCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE [bit3444_hw3].[tblAirports] SET [Code] = @Code, [City] = @City, [State] = @State, [Name] = @Name, [Active] = @Active, [Lat] = @Lat, [Long] = @Long WHERE (([Code] = @Original_Code) AND ([City] = @Original_City) AND ((@IsNull_State = 1 AND [State] IS NULL) OR ([State] = @Original_State)) AND ([Name] = @Original_Name) AND ((@IsNull_Active = 1 AND [Active] IS NULL) OR ([Active] = @Original_Active)) AND ((@IsNull_Lat = 1 AND [Lat] IS NULL) OR ([Lat] = @Original_Lat)) AND ((@IsNull_Long = 1 AND [Long] IS NULL) OR ([Long] = @Original_Long)));\r\nSELECT Code, City, State, Name, Active, Lat, Long FROM tblAirports WHERE (Code = @Code)";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Code", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Code", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@City", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "City", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@State", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "State", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Name", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Active", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Active", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Lat", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Lat", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Long", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Long", DataRowVersion.Current, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Code", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Code", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_City", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "City", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_State", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "State", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_State", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "State", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Name", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Name", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Active", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Active", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Active", SqlDbType.Bit, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Active", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Lat", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Lat", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Lat", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Lat", DataRowVersion.Original, false, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Long", SqlDbType.Int, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Long", DataRowVersion.Original, true, (object) null, "", "", ""));
      this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Long", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Long", DataRowVersion.Original, false, (object) null, "", "", ""));
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
      this._commandCollection[0].CommandText = "SELECT Code, City, State, Name, Active, Lat, Long FROM bit3444_hw3.tblAirports";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(bit3444_dataset.tblAirportsDataTable dataTable)
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
    public virtual bit3444_dataset.tblAirportsDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      bit3444_dataset.tblAirportsDataTable airportsDataTable = new bit3444_dataset.tblAirportsDataTable();
      this.Adapter.Fill((DataTable) airportsDataTable);
      return airportsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bit3444_dataset.tblAirportsDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(bit3444_dataset dataSet) => this.Adapter.Update((DataSet) dataSet, "tblAirports");

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
      string Original_Code,
      string Original_City,
      string Original_State,
      string Original_Name,
      bool? Original_Active,
      string Original_Lat,
      string Original_Long)
    {
      this.Adapter.DeleteCommand.Parameters[0].Value = Original_Code != null ? (object) Original_Code : throw new ArgumentNullException(nameof (Original_Code));
      this.Adapter.DeleteCommand.Parameters[1].Value = Original_City != null ? (object) Original_City : throw new ArgumentNullException(nameof (Original_City));
      if (Original_State == null)
      {
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[2].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[3].Value = (object) Original_State;
      }
      this.Adapter.DeleteCommand.Parameters[4].Value = Original_Name != null ? (object) Original_Name : throw new ArgumentNullException(nameof (Original_Name));
      if (Original_Active.HasValue)
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) Original_Active.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[5].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[6].Value = (object) DBNull.Value;
      }
      if (Original_Lat == null)
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[7].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[8].Value = (object) Original_Lat;
      }
      if (Original_Long == null)
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 1;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.DeleteCommand.Parameters[9].Value = (object) 0;
        this.Adapter.DeleteCommand.Parameters[10].Value = (object) Original_Long;
      }
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
    public virtual int Insert(
      string Code,
      string City,
      string State,
      string Name,
      bool? Active,
      string Lat,
      string _Long)
    {
      this.Adapter.InsertCommand.Parameters[0].Value = Code != null ? (object) Code : throw new ArgumentNullException(nameof (Code));
      this.Adapter.InsertCommand.Parameters[1].Value = City != null ? (object) City : throw new ArgumentNullException(nameof (City));
      this.Adapter.InsertCommand.Parameters[2].Value = State != null ? (object) State : (object) DBNull.Value;
      this.Adapter.InsertCommand.Parameters[3].Value = Name != null ? (object) Name : throw new ArgumentNullException(nameof (Name));
      this.Adapter.InsertCommand.Parameters[4].Value = !Active.HasValue ? (object) DBNull.Value : (object) Active.Value;
      this.Adapter.InsertCommand.Parameters[5].Value = Lat != null ? (object) Lat : (object) DBNull.Value;
      this.Adapter.InsertCommand.Parameters[6].Value = _Long != null ? (object) _Long : (object) DBNull.Value;
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
      string Code,
      string City,
      string State,
      string Name,
      bool? Active,
      string Lat,
      string _Long,
      string Original_Code,
      string Original_City,
      string Original_State,
      string Original_Name,
      bool? Original_Active,
      string Original_Lat,
      string Original_Long)
    {
      this.Adapter.UpdateCommand.Parameters[0].Value = Code != null ? (object) Code : throw new ArgumentNullException(nameof (Code));
      this.Adapter.UpdateCommand.Parameters[1].Value = City != null ? (object) City : throw new ArgumentNullException(nameof (City));
      this.Adapter.UpdateCommand.Parameters[2].Value = State != null ? (object) State : (object) DBNull.Value;
      this.Adapter.UpdateCommand.Parameters[3].Value = Name != null ? (object) Name : throw new ArgumentNullException(nameof (Name));
      this.Adapter.UpdateCommand.Parameters[4].Value = !Active.HasValue ? (object) DBNull.Value : (object) Active.Value;
      this.Adapter.UpdateCommand.Parameters[5].Value = Lat != null ? (object) Lat : (object) DBNull.Value;
      this.Adapter.UpdateCommand.Parameters[6].Value = _Long != null ? (object) _Long : (object) DBNull.Value;
      this.Adapter.UpdateCommand.Parameters[7].Value = Original_Code != null ? (object) Original_Code : throw new ArgumentNullException(nameof (Original_Code));
      this.Adapter.UpdateCommand.Parameters[8].Value = Original_City != null ? (object) Original_City : throw new ArgumentNullException(nameof (Original_City));
      if (Original_State == null)
      {
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[9].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[10].Value = (object) Original_State;
      }
      this.Adapter.UpdateCommand.Parameters[11].Value = Original_Name != null ? (object) Original_Name : throw new ArgumentNullException(nameof (Original_Name));
      if (Original_Active.HasValue)
      {
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) Original_Active.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[12].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[13].Value = (object) DBNull.Value;
      }
      if (Original_Lat == null)
      {
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[14].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[15].Value = (object) Original_Lat;
      }
      if (Original_Long == null)
      {
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) 1;
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) DBNull.Value;
      }
      else
      {
        this.Adapter.UpdateCommand.Parameters[16].Value = (object) 0;
        this.Adapter.UpdateCommand.Parameters[17].Value = (object) Original_Long;
      }
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
      string City,
      string State,
      string Name,
      bool? Active,
      string Lat,
      string _Long,
      string Original_Code,
      string Original_City,
      string Original_State,
      string Original_Name,
      bool? Original_Active,
      string Original_Lat,
      string Original_Long)
    {
      return this.Update(Original_Code, City, State, Name, Active, Lat, _Long, Original_Code, Original_City, Original_State, Original_Name, Original_Active, Original_Lat, Original_Long);
    }
  }
}
