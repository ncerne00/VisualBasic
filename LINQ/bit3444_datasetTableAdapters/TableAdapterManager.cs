// Decompiled with JetBrains decompiler
// Type: LINQ.bit3444_datasetTableAdapters.TableAdapterManager
// Assembly: LINQ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ADC7924A-8176-4616-8423-22FB7B9F821F
// Assembly location: C:\Users\Nick\Downloads\LINQ.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace LINQ.bit3444_datasetTableAdapters
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapterManager")]
  public class TableAdapterManager : Component
  {
    private TableAdapterManager.UpdateOrderOption _updateOrder;
    private tblAirportsTableAdapter _tblAirportsTableAdapter;
    private tblFlightsTableAdapter _tblFlightsTableAdapter;
    private bool _backupDataSetBeforeUpdate;
    private IDbConnection _connection;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public TableAdapterManager.UpdateOrderOption UpdateOrder
    {
      get => this._updateOrder;
      set => this._updateOrder = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public tblAirportsTableAdapter tblAirportsTableAdapter
    {
      get => this._tblAirportsTableAdapter;
      set => this._tblAirportsTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    public tblFlightsTableAdapter tblFlightsTableAdapter
    {
      get => this._tblFlightsTableAdapter;
      set => this._tblFlightsTableAdapter = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bool BackupDataSetBeforeUpdate
    {
      get => this._backupDataSetBeforeUpdate;
      set => this._backupDataSetBeforeUpdate = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public IDbConnection Connection
    {
      get => this._connection == null ? (this._tblAirportsTableAdapter == null || this._tblAirportsTableAdapter.Connection == null ? (this._tblFlightsTableAdapter == null || this._tblFlightsTableAdapter.Connection == null ? (IDbConnection) null : (IDbConnection) this._tblFlightsTableAdapter.Connection) : (IDbConnection) this._tblAirportsTableAdapter.Connection) : this._connection;
      set => this._connection = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    public int TableAdapterInstanceCount
    {
      get
      {
        int num = 0;
        if (this._tblAirportsTableAdapter != null)
          checked { ++num; }
        if (this._tblFlightsTableAdapter != null)
          checked { ++num; }
        return num;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private int UpdateUpdatedRows(
      bit3444_dataset dataSet,
      List<DataRow> allChangedRows,
      List<DataRow> allAddedRows)
    {
      int num = 0;
      if (this._tblAirportsTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.tblAirports.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          checked { num += this._tblAirportsTableAdapter.Update(realUpdatedRows); }
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      if (this._tblFlightsTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.tblFlights.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          checked { num += this._tblFlightsTableAdapter.Update(realUpdatedRows); }
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private int UpdateInsertedRows(bit3444_dataset dataSet, List<DataRow> allAddedRows)
    {
      int num = 0;
      if (this._tblAirportsTableAdapter != null)
      {
        DataRow[] dataRows = dataSet.tblAirports.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRows != null && 0 < dataRows.Length)
        {
          checked { num += this._tblAirportsTableAdapter.Update(dataRows); }
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRows);
        }
      }
      if (this._tblFlightsTableAdapter != null)
      {
        DataRow[] dataRows = dataSet.tblFlights.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRows != null && 0 < dataRows.Length)
        {
          checked { num += this._tblFlightsTableAdapter.Update(dataRows); }
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRows);
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private int UpdateDeletedRows(bit3444_dataset dataSet, List<DataRow> allChangedRows)
    {
      int num = 0;
      if (this._tblFlightsTableAdapter != null)
      {
        DataRow[] dataRows = dataSet.tblFlights.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRows != null && 0 < dataRows.Length)
        {
          checked { num += this._tblFlightsTableAdapter.Update(dataRows); }
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRows);
        }
      }
      if (this._tblAirportsTableAdapter != null)
      {
        DataRow[] dataRows = dataSet.tblAirports.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRows != null && 0 < dataRows.Length)
        {
          checked { num += this._tblAirportsTableAdapter.Update(dataRows); }
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRows);
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
    {
      DataRow[] dataRowArray;
      if (updatedRows == null || updatedRows.Length < 1)
        dataRowArray = updatedRows;
      else if (allAddedRows == null || allAddedRows.Count < 1)
      {
        dataRowArray = updatedRows;
      }
      else
      {
        List<DataRow> dataRowList = new List<DataRow>();
        int index = 0;
        while (index < updatedRows.Length)
        {
          DataRow updatedRow = updatedRows[index];
          if (!allAddedRows.Contains(updatedRow))
            dataRowList.Add(updatedRow);
          checked { ++index; }
        }
        dataRowArray = dataRowList.ToArray();
      }
      return dataRowArray;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public virtual int UpdateAll(bit3444_dataset dataSet)
    {
      if (dataSet == null)
        throw new ArgumentNullException(nameof (dataSet));
      int num1;
      if (!dataSet.HasChanges())
      {
        num1 = 0;
      }
      else
      {
        if (this._tblAirportsTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tblAirportsTableAdapter.Connection))
          throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
        if (this._tblFlightsTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._tblFlightsTableAdapter.Connection))
          throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
        IDbConnection connection = this.Connection;
        if (connection == null)
          throw new ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.");
        bool flag = false;
        if ((connection.State & ConnectionState.Broken) == ConnectionState.Broken)
          connection.Close();
        if (connection.State == ConnectionState.Closed)
        {
          connection.Open();
          flag = true;
        }
        IDbTransaction dbTransaction = connection.BeginTransaction();
        if (dbTransaction == null)
          throw new ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.");
        List<DataRow> allChangedRows = new List<DataRow>();
        List<DataRow> allAddedRows = new List<DataRow>();
        List<DataAdapter> dataAdapterList = new List<DataAdapter>();
        Dictionary<object, IDbConnection> dictionary = new Dictionary<object, IDbConnection>();
        int num2 = 0;
        DataSet dataSet1 = (DataSet) null;
        if (this.BackupDataSetBeforeUpdate)
        {
          dataSet1 = new DataSet();
          dataSet1.Merge((DataSet) dataSet);
        }
        try
        {
          if (this._tblAirportsTableAdapter != null)
          {
            dictionary.Add((object) this._tblAirportsTableAdapter, (IDbConnection) this._tblAirportsTableAdapter.Connection);
            this._tblAirportsTableAdapter.Connection = (SqlConnection) connection;
            this._tblAirportsTableAdapter.Transaction = (SqlTransaction) dbTransaction;
            if (this._tblAirportsTableAdapter.Adapter.AcceptChangesDuringUpdate)
            {
              this._tblAirportsTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
              dataAdapterList.Add((DataAdapter) this._tblAirportsTableAdapter.Adapter);
            }
          }
          if (this._tblFlightsTableAdapter != null)
          {
            dictionary.Add((object) this._tblFlightsTableAdapter, (IDbConnection) this._tblFlightsTableAdapter.Connection);
            this._tblFlightsTableAdapter.Connection = (SqlConnection) connection;
            this._tblFlightsTableAdapter.Transaction = (SqlTransaction) dbTransaction;
            if (this._tblFlightsTableAdapter.Adapter.AcceptChangesDuringUpdate)
            {
              this._tblFlightsTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
              dataAdapterList.Add((DataAdapter) this._tblFlightsTableAdapter.Adapter);
            }
          }
          if (this.UpdateOrder == TableAdapterManager.UpdateOrderOption.UpdateInsertDelete)
          {
            checked { num2 += this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows); }
            checked { num2 += this.UpdateInsertedRows(dataSet, allAddedRows); }
          }
          else
          {
            checked { num2 += this.UpdateInsertedRows(dataSet, allAddedRows); }
            checked { num2 += this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows); }
          }
          checked { num2 += this.UpdateDeletedRows(dataSet, allChangedRows); }
          dbTransaction.Commit();
          if (0 < allAddedRows.Count)
          {
            DataRow[] array = new DataRow[checked (allAddedRows.Count - 1 + 1)];
            allAddedRows.CopyTo(array);
            int index = 0;
            while (index < array.Length)
            {
              array[index].AcceptChanges();
              checked { ++index; }
            }
          }
          if (0 < allChangedRows.Count)
          {
            DataRow[] array = new DataRow[checked (allChangedRows.Count - 1 + 1)];
            allChangedRows.CopyTo(array);
            int index = 0;
            while (index < array.Length)
            {
              array[index].AcceptChanges();
              checked { ++index; }
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          dbTransaction.Rollback();
          if (this.BackupDataSetBeforeUpdate)
          {
            dataSet.Clear();
            dataSet.Merge(dataSet1);
          }
          else if (0 < allAddedRows.Count)
          {
            DataRow[] array = new DataRow[checked (allAddedRows.Count - 1 + 1)];
            allAddedRows.CopyTo(array);
            int index = 0;
            while (index < array.Length)
            {
              DataRow dataRow = array[index];
              dataRow.AcceptChanges();
              dataRow.SetAdded();
              checked { ++index; }
            }
          }
          throw exception;
        }
        finally
        {
          if (flag)
            connection.Close();
          if (this._tblAirportsTableAdapter != null)
          {
            this._tblAirportsTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tblAirportsTableAdapter];
            this._tblAirportsTableAdapter.Transaction = (SqlTransaction) null;
          }
          if (this._tblFlightsTableAdapter != null)
          {
            this._tblFlightsTableAdapter.Connection = (SqlConnection) dictionary[(object) this._tblFlightsTableAdapter];
            this._tblFlightsTableAdapter.Transaction = (SqlTransaction) null;
          }
          if (0 < dataAdapterList.Count)
          {
            DataAdapter[] array = new DataAdapter[checked (dataAdapterList.Count - 1 + 1)];
            dataAdapterList.CopyTo(array);
            int index = 0;
            while (index < array.Length)
            {
              array[index].AcceptChangesDuringUpdate = true;
              checked { ++index; }
            }
          }
        }
        num1 = num2;
      }
      return num1;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected virtual void SortSelfReferenceRows(
      DataRow[] rows,
      DataRelation relation,
      bool childFirst)
    {
      Array.Sort<DataRow>(rows, (IComparer<DataRow>) new TableAdapterManager.SelfReferenceComparer(relation, childFirst));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection) => this._connection != null || (this.Connection == null || inputConnection == null || string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal));

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public enum UpdateOrderOption
    {
      InsertUpdateDelete,
      UpdateInsertDelete,
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private class SelfReferenceComparer : IComparer<DataRow>
    {
      private DataRelation _relation;
      private int _childFirst;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal SelfReferenceComparer(DataRelation relation, bool childFirst)
      {
        this._relation = relation;
        if (childFirst)
          this._childFirst = -1;
        else
          this._childFirst = 1;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private DataRow GetRoot(DataRow row, ref int distance)
      {
        DataRow dataRow = row;
        distance = 0;
        IDictionary<DataRow, DataRow> dictionary = (IDictionary<DataRow, DataRow>) new Dictionary<DataRow, DataRow>();
        dictionary[row] = row;
        for (DataRow parentRow = row.GetParentRow(this._relation, DataRowVersion.Default); parentRow != null && !dictionary.ContainsKey(parentRow); parentRow = parentRow.GetParentRow(this._relation, DataRowVersion.Default))
        {
          checked { ++distance; }
          dataRow = parentRow;
          dictionary[parentRow] = parentRow;
        }
        if (distance == 0)
        {
          dictionary.Clear();
          dictionary[row] = row;
          for (DataRow parentRow = row.GetParentRow(this._relation, DataRowVersion.Original); parentRow != null && !dictionary.ContainsKey(parentRow); parentRow = parentRow.GetParentRow(this._relation, DataRowVersion.Original))
          {
            checked { ++distance; }
            dataRow = parentRow;
            dictionary[parentRow] = parentRow;
          }
        }
        return dataRow;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int Compare(DataRow row1, DataRow row2)
      {
        int num;
        if (object.ReferenceEquals((object) row1, (object) row2))
          num = 0;
        else if (row1 == null)
          num = -1;
        else if (row2 == null)
        {
          num = 1;
        }
        else
        {
          int distance1 = 0;
          DataRow root1 = this.GetRoot(row1, ref distance1);
          int distance2 = 0;
          DataRow root2 = this.GetRoot(row2, ref distance2);
          num = !object.ReferenceEquals((object) root1, (object) root2) ? (root1.Table.Rows.IndexOf(root1) >= root2.Table.Rows.IndexOf(root2) ? 1 : -1) : checked (this._childFirst * distance1.CompareTo(distance2));
        }
        return num;
      }
    }
  }
}
