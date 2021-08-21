// Decompiled with JetBrains decompiler
// Type: LINQ.bit3444_dataset
// Assembly: LINQ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ADC7924A-8176-4616-8423-22FB7B9F821F
// Assembly location: C:\Users\Nick\Downloads\LINQ.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace LINQ
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [XmlRoot("bit3444_dataset")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class bit3444_dataset : DataSet
  {
    private bit3444_dataset.tblAirportsDataTable tabletblAirports;
    private bit3444_dataset.tblFlightsDataTable tabletblFlights;
    private DataRelation relationFK_tblFlights_tblAirports;
    private DataRelation relationFK_tblFlights_tblAirports1;
    private SchemaSerializationMode _schemaSerializationMode;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public bit3444_dataset()
    {
      this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.BeginInit();
      this.InitClass();
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      base.Relations.CollectionChanged += changeEventHandler;
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected bit3444_dataset(SerializationInfo info, StreamingContext context)
      : base(info, context, false)
    {
      this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      if (this.IsBinarySerialized(info, context))
      {
        this.InitVars(false);
        CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
        this.Tables.CollectionChanged += changeEventHandler;
        this.Relations.CollectionChanged += changeEventHandler;
      }
      else
      {
        string s = Conversions.ToString(info.GetValue("XmlSchema", typeof (string)));
        if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
        {
          DataSet dataSet = new DataSet();
          dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
          if (dataSet.Tables[nameof (tblAirports)] != null)
            base.Tables.Add((DataTable) new bit3444_dataset.tblAirportsDataTable(dataSet.Tables[nameof (tblAirports)]));
          if (dataSet.Tables[nameof (tblFlights)] != null)
            base.Tables.Add((DataTable) new bit3444_dataset.tblFlightsDataTable(dataSet.Tables[nameof (tblFlights)]));
          this.DataSetName = dataSet.DataSetName;
          this.Prefix = dataSet.Prefix;
          this.Namespace = dataSet.Namespace;
          this.Locale = dataSet.Locale;
          this.CaseSensitive = dataSet.CaseSensitive;
          this.EnforceConstraints = dataSet.EnforceConstraints;
          this.Merge(dataSet, false, MissingSchemaAction.Add);
          this.InitVars();
        }
        else
          this.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        this.GetSerializationData(info, context);
        CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
        base.Tables.CollectionChanged += changeEventHandler;
        this.Relations.CollectionChanged += changeEventHandler;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public bit3444_dataset.tblAirportsDataTable tblAirports => this.tabletblAirports;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public bit3444_dataset.tblFlightsDataTable tblFlights => this.tabletblFlights;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public override SchemaSerializationMode SchemaSerializationMode
    {
      get => this._schemaSerializationMode;
      set => this._schemaSerializationMode = value;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new DataTableCollection Tables => base.Tables;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new DataRelationCollection Relations => base.Relations;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void InitializeDerivedDataSet()
    {
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public override DataSet Clone()
    {
      bit3444_dataset bit3444Dataset = (bit3444_dataset) base.Clone();
      bit3444Dataset.InitVars();
      bit3444Dataset.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) bit3444Dataset;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override bool ShouldSerializeTables() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override bool ShouldSerializeRelations() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override void ReadXmlSerializable(XmlReader reader)
    {
      if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
      {
        this.Reset();
        DataSet dataSet = new DataSet();
        int num = (int) dataSet.ReadXml(reader);
        if (dataSet.Tables["tblAirports"] != null)
          base.Tables.Add((DataTable) new bit3444_dataset.tblAirportsDataTable(dataSet.Tables["tblAirports"]));
        if (dataSet.Tables["tblFlights"] != null)
          base.Tables.Add((DataTable) new bit3444_dataset.tblFlightsDataTable(dataSet.Tables["tblFlights"]));
        this.DataSetName = dataSet.DataSetName;
        this.Prefix = dataSet.Prefix;
        this.Namespace = dataSet.Namespace;
        this.Locale = dataSet.Locale;
        this.CaseSensitive = dataSet.CaseSensitive;
        this.EnforceConstraints = dataSet.EnforceConstraints;
        this.Merge(dataSet, false, MissingSchemaAction.Add);
        this.InitVars();
      }
      else
      {
        int num = (int) this.ReadXml(reader);
        this.InitVars();
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    protected override XmlSchema GetSchemaSerializable()
    {
      MemoryStream memoryStream = new MemoryStream();
      this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
      memoryStream.Position = 0L;
      return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars() => this.InitVars(true);

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    internal void InitVars(bool initTable)
    {
      this.tabletblAirports = (bit3444_dataset.tblAirportsDataTable) base.Tables["tblAirports"];
      if (initTable && this.tabletblAirports != null)
        this.tabletblAirports.InitVars();
      this.tabletblFlights = (bit3444_dataset.tblFlightsDataTable) base.Tables["tblFlights"];
      if (initTable && this.tabletblFlights != null)
        this.tabletblFlights.InitVars();
      this.relationFK_tblFlights_tblAirports = this.Relations["FK_tblFlights_tblAirports"];
      this.relationFK_tblFlights_tblAirports1 = this.Relations["FK_tblFlights_tblAirports1"];
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = nameof (bit3444_dataset);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/bit3444_dataset.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tabletblAirports = new bit3444_dataset.tblAirportsDataTable();
      base.Tables.Add((DataTable) this.tabletblAirports);
      this.tabletblFlights = new bit3444_dataset.tblFlightsDataTable();
      base.Tables.Add((DataTable) this.tabletblFlights);
      this.relationFK_tblFlights_tblAirports = new DataRelation("FK_tblFlights_tblAirports", new DataColumn[1]
      {
        this.tabletblAirports.CodeColumn
      }, new DataColumn[1]
      {
        this.tabletblFlights.arriveATColumn
      }, false);
      this.Relations.Add(this.relationFK_tblFlights_tblAirports);
      this.relationFK_tblFlights_tblAirports1 = new DataRelation("FK_tblFlights_tblAirports1", new DataColumn[1]
      {
        this.tabletblAirports.CodeColumn
      }, new DataColumn[1]
      {
        this.tabletblFlights.departFROMColumn
      }, false);
      this.Relations.Add(this.relationFK_tblFlights_tblAirports1);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializetblAirports() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private bool ShouldSerializetblFlights() => false;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    private void SchemaChanged(object sender, CollectionChangeEventArgs e)
    {
      if (e.Action != CollectionChangeAction.Remove)
        return;
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
    {
      bit3444_dataset bit3444Dataset = new bit3444_dataset();
      XmlSchemaComplexType schemaComplexType1 = new XmlSchemaComplexType();
      schemaComplexType1.Particle = (XmlSchemaParticle) new XmlSchemaSequence()
      {
        Items = {
          (XmlSchemaObject) new XmlSchemaAny()
          {
            Namespace = bit3444Dataset.Namespace
          }
        }
      };
      XmlSchema schemaSerializable = bit3444Dataset.GetSchemaSerializable();
      XmlSchemaComplexType schemaComplexType2;
      if (xs.Contains(schemaSerializable.TargetNamespace))
      {
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          schemaSerializable.Write((Stream) memoryStream1);
          IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
          while (enumerator.MoveNext())
          {
            XmlSchema current = (XmlSchema) enumerator.Current;
            memoryStream2.SetLength(0L);
            MemoryStream memoryStream3 = memoryStream2;
            current.Write((Stream) memoryStream3);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
              {
                schemaComplexType2 = schemaComplexType1;
                goto label_15;
              }
            }
          }
        }
        finally
        {
          memoryStream1?.Close();
          memoryStream2?.Close();
        }
      }
      xs.Add(schemaSerializable);
      schemaComplexType2 = schemaComplexType1;
label_15:
      return schemaComplexType2;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public delegate void tblAirportsRowChangeEventHandler(
      object sender,
      bit3444_dataset.tblAirportsRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public delegate void tblFlightsRowChangeEventHandler(
      object sender,
      bit3444_dataset.tblFlightsRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class tblAirportsDataTable : TypedTableBase<bit3444_dataset.tblAirportsRow>
    {
      private DataColumn columnCode;
      private DataColumn columnCity;
      private DataColumn columnState;
      private DataColumn columnName;
      private DataColumn columnActive;
      private DataColumn columnLat;
      private DataColumn columnLong;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public tblAirportsDataTable()
      {
        this.TableName = "tblAirports";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal tblAirportsDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
          this.Locale = table.Locale;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected tblAirportsDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
        => this.InitVars();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CodeColumn => this.columnCode;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn CityColumn => this.columnCity;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn StateColumn => this.columnState;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn NameColumn => this.columnName;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn ActiveColumn => this.columnActive;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn LatColumn => this.columnLat;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn LongColumn => this.columnLong;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bit3444_dataset.tblAirportsRow this[int index] => (bit3444_dataset.tblAirportsRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event bit3444_dataset.tblAirportsRowChangeEventHandler tblAirportsRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event bit3444_dataset.tblAirportsRowChangeEventHandler tblAirportsRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event bit3444_dataset.tblAirportsRowChangeEventHandler tblAirportsRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event bit3444_dataset.tblAirportsRowChangeEventHandler tblAirportsRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddtblAirportsRow(bit3444_dataset.tblAirportsRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bit3444_dataset.tblAirportsRow AddtblAirportsRow(
        string Code,
        string City,
        string State,
        string Name,
        bool Active,
        string Lat,
        string _Long)
      {
        bit3444_dataset.tblAirportsRow tblAirportsRow = (bit3444_dataset.tblAirportsRow) this.NewRow();
        object[] objArray = new object[7]
        {
          (object) Code,
          (object) City,
          (object) State,
          (object) Name,
          (object) Active,
          (object) Lat,
          (object) _Long
        };
        tblAirportsRow.ItemArray = objArray;
        this.Rows.Add((DataRow) tblAirportsRow);
        return tblAirportsRow;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bit3444_dataset.tblAirportsRow FindByCode(string Code) => (bit3444_dataset.tblAirportsRow) this.Rows.Find(new object[1]
      {
        (object) Code
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        bit3444_dataset.tblAirportsDataTable airportsDataTable = (bit3444_dataset.tblAirportsDataTable) base.Clone();
        airportsDataTable.InitVars();
        return (DataTable) airportsDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new bit3444_dataset.tblAirportsDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnCode = this.Columns["Code"];
        this.columnCity = this.Columns["City"];
        this.columnState = this.Columns["State"];
        this.columnName = this.Columns["Name"];
        this.columnActive = this.Columns["Active"];
        this.columnLat = this.Columns["Lat"];
        this.columnLong = this.Columns["Long"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnCode = new DataColumn("Code", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCode);
        this.columnCity = new DataColumn("City", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCity);
        this.columnState = new DataColumn("State", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnState);
        this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnName);
        this.columnActive = new DataColumn("Active", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnActive);
        this.columnLat = new DataColumn("Lat", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnLat);
        this.columnLong = new DataColumn("Long", typeof (string), (string) null, MappingType.Element);
        this.columnLong.ExtendedProperties.Add((object) "Generator_ColumnPropNameInTable", (object) "LongColumn");
        this.columnLong.ExtendedProperties.Add((object) "Generator_ColumnVarNameInTable", (object) "columnLong");
        this.columnLong.ExtendedProperties.Add((object) "Generator_UserColumnName", (object) "Long");
        this.Columns.Add(this.columnLong);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnCode
        }, true));
        this.columnCode.AllowDBNull = false;
        this.columnCode.Unique = true;
        this.columnCode.MaxLength = 10;
        this.columnCity.AllowDBNull = false;
        this.columnCity.MaxLength = 500;
        this.columnState.MaxLength = 2;
        this.columnName.AllowDBNull = false;
        this.columnName.MaxLength = 500;
        this.columnLat.MaxLength = 1000;
        this.columnLong.MaxLength = 1000;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bit3444_dataset.tblAirportsRow NewtblAirportsRow() => (bit3444_dataset.tblAirportsRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new bit3444_dataset.tblAirportsRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (bit3444_dataset.tblAirportsRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        // ISSUE: reference to a compiler-generated field
        if (this.tblAirportsRowChangedEvent == null)
          return;
        // ISSUE: reference to a compiler-generated field
        bit3444_dataset.tblAirportsRowChangeEventHandler airportsRowChangedEvent = this.tblAirportsRowChangedEvent;
        if (airportsRowChangedEvent == null)
          return;
        airportsRowChangedEvent((object) this, new bit3444_dataset.tblAirportsRowChangeEvent((bit3444_dataset.tblAirportsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        // ISSUE: reference to a compiler-generated field
        if (this.tblAirportsRowChangingEvent == null)
          return;
        // ISSUE: reference to a compiler-generated field
        bit3444_dataset.tblAirportsRowChangeEventHandler rowChangingEvent = this.tblAirportsRowChangingEvent;
        if (rowChangingEvent == null)
          return;
        rowChangingEvent((object) this, new bit3444_dataset.tblAirportsRowChangeEvent((bit3444_dataset.tblAirportsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        // ISSUE: reference to a compiler-generated field
        if (this.tblAirportsRowDeletedEvent == null)
          return;
        // ISSUE: reference to a compiler-generated field
        bit3444_dataset.tblAirportsRowChangeEventHandler airportsRowDeletedEvent = this.tblAirportsRowDeletedEvent;
        if (airportsRowDeletedEvent == null)
          return;
        airportsRowDeletedEvent((object) this, new bit3444_dataset.tblAirportsRowChangeEvent((bit3444_dataset.tblAirportsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        // ISSUE: reference to a compiler-generated field
        if (this.tblAirportsRowDeletingEvent == null)
          return;
        // ISSUE: reference to a compiler-generated field
        bit3444_dataset.tblAirportsRowChangeEventHandler rowDeletingEvent = this.tblAirportsRowDeletingEvent;
        if (rowDeletingEvent == null)
          return;
        rowDeletingEvent((object) this, new bit3444_dataset.tblAirportsRowChangeEvent((bit3444_dataset.tblAirportsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemovetblAirportsRow(bit3444_dataset.tblAirportsRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType1 = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        bit3444_dataset bit3444Dataset = new bit3444_dataset();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        schemaComplexType1.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = bit3444Dataset.Namespace
        });
        schemaComplexType1.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (tblAirportsDataTable)
        });
        schemaComplexType1.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = bit3444Dataset.GetSchemaSerializable();
        XmlSchemaComplexType schemaComplexType2;
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              MemoryStream memoryStream3 = memoryStream2;
              current.Write((Stream) memoryStream3);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                {
                  schemaComplexType2 = schemaComplexType1;
                  goto label_15;
                }
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        schemaComplexType2 = schemaComplexType1;
label_15:
        return schemaComplexType2;
      }
    }

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class tblFlightsDataTable : TypedTableBase<bit3444_dataset.tblFlightsRow>
    {
      private DataColumn columnflightID;
      private DataColumn columndepartFROM;
      private DataColumn columnarriveAT;
      private DataColumn columndistance;
      private DataColumn columnactive;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public tblFlightsDataTable()
      {
        this.TableName = "tblFlights";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal tblFlightsDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
          this.Locale = table.Locale;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected tblFlightsDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
        => this.InitVars();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn flightIDColumn => this.columnflightID;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn departFROMColumn => this.columndepartFROM;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn arriveATColumn => this.columnarriveAT;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn distanceColumn => this.columndistance;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataColumn activeColumn => this.columnactive;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bit3444_dataset.tblFlightsRow this[int index] => (bit3444_dataset.tblFlightsRow) this.Rows[index];

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event bit3444_dataset.tblFlightsRowChangeEventHandler tblFlightsRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event bit3444_dataset.tblFlightsRowChangeEventHandler tblFlightsRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event bit3444_dataset.tblFlightsRowChangeEventHandler tblFlightsRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public event bit3444_dataset.tblFlightsRowChangeEventHandler tblFlightsRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void AddtblFlightsRow(bit3444_dataset.tblFlightsRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bit3444_dataset.tblFlightsRow AddtblFlightsRow(
        bit3444_dataset.tblAirportsRow parenttblAirportsRowByFK_tblFlights_tblAirports1,
        bit3444_dataset.tblAirportsRow parenttblAirportsRowByFK_tblFlights_tblAirports,
        Decimal distance,
        bool active)
      {
        bit3444_dataset.tblFlightsRow tblFlightsRow = (bit3444_dataset.tblFlightsRow) this.NewRow();
        object[] objArray = new object[5]
        {
          null,
          null,
          null,
          (object) distance,
          (object) active
        };
        if (parenttblAirportsRowByFK_tblFlights_tblAirports1 != null)
          objArray[1] = RuntimeHelpers.GetObjectValue(parenttblAirportsRowByFK_tblFlights_tblAirports1[0]);
        if (parenttblAirportsRowByFK_tblFlights_tblAirports != null)
          objArray[2] = RuntimeHelpers.GetObjectValue(parenttblAirportsRowByFK_tblFlights_tblAirports[0]);
        tblFlightsRow.ItemArray = objArray;
        this.Rows.Add((DataRow) tblFlightsRow);
        return tblFlightsRow;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bit3444_dataset.tblFlightsRow FindByflightID(int flightID) => (bit3444_dataset.tblFlightsRow) this.Rows.Find(new object[1]
      {
        (object) flightID
      });

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public override DataTable Clone()
      {
        bit3444_dataset.tblFlightsDataTable flightsDataTable = (bit3444_dataset.tblFlightsDataTable) base.Clone();
        flightsDataTable.InitVars();
        return (DataTable) flightsDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataTable CreateInstance() => (DataTable) new bit3444_dataset.tblFlightsDataTable();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal void InitVars()
      {
        this.columnflightID = this.Columns["flightID"];
        this.columndepartFROM = this.Columns["departFROM"];
        this.columnarriveAT = this.Columns["arriveAT"];
        this.columndistance = this.Columns["distance"];
        this.columnactive = this.Columns["active"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      private void InitClass()
      {
        this.columnflightID = new DataColumn("flightID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnflightID);
        this.columndepartFROM = new DataColumn("departFROM", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columndepartFROM);
        this.columnarriveAT = new DataColumn("arriveAT", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnarriveAT);
        this.columndistance = new DataColumn("distance", typeof (Decimal), (string) null, MappingType.Element);
        this.Columns.Add(this.columndistance);
        this.columnactive = new DataColumn("active", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnactive);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnflightID
        }, true));
        this.columnflightID.AutoIncrement = true;
        this.columnflightID.AutoIncrementSeed = -1L;
        this.columnflightID.AutoIncrementStep = -1L;
        this.columnflightID.AllowDBNull = false;
        this.columnflightID.ReadOnly = true;
        this.columnflightID.Unique = true;
        this.columndepartFROM.AllowDBNull = false;
        this.columndepartFROM.MaxLength = 10;
        this.columnarriveAT.AllowDBNull = false;
        this.columnarriveAT.MaxLength = 10;
        this.columndistance.AllowDBNull = false;
        this.columnactive.AllowDBNull = false;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bit3444_dataset.tblFlightsRow NewtblFlightsRow() => (bit3444_dataset.tblFlightsRow) this.NewRow();

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new bit3444_dataset.tblFlightsRow(builder);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override Type GetRowType() => typeof (bit3444_dataset.tblFlightsRow);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        // ISSUE: reference to a compiler-generated field
        if (this.tblFlightsRowChangedEvent == null)
          return;
        // ISSUE: reference to a compiler-generated field
        bit3444_dataset.tblFlightsRowChangeEventHandler flightsRowChangedEvent = this.tblFlightsRowChangedEvent;
        if (flightsRowChangedEvent == null)
          return;
        flightsRowChangedEvent((object) this, new bit3444_dataset.tblFlightsRowChangeEvent((bit3444_dataset.tblFlightsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        // ISSUE: reference to a compiler-generated field
        if (this.tblFlightsRowChangingEvent == null)
          return;
        // ISSUE: reference to a compiler-generated field
        bit3444_dataset.tblFlightsRowChangeEventHandler rowChangingEvent = this.tblFlightsRowChangingEvent;
        if (rowChangingEvent == null)
          return;
        rowChangingEvent((object) this, new bit3444_dataset.tblFlightsRowChangeEvent((bit3444_dataset.tblFlightsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        // ISSUE: reference to a compiler-generated field
        if (this.tblFlightsRowDeletedEvent == null)
          return;
        // ISSUE: reference to a compiler-generated field
        bit3444_dataset.tblFlightsRowChangeEventHandler flightsRowDeletedEvent = this.tblFlightsRowDeletedEvent;
        if (flightsRowDeletedEvent == null)
          return;
        flightsRowDeletedEvent((object) this, new bit3444_dataset.tblFlightsRowChangeEvent((bit3444_dataset.tblFlightsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        // ISSUE: reference to a compiler-generated field
        if (this.tblFlightsRowDeletingEvent == null)
          return;
        // ISSUE: reference to a compiler-generated field
        bit3444_dataset.tblFlightsRowChangeEventHandler rowDeletingEvent = this.tblFlightsRowDeletingEvent;
        if (rowDeletingEvent == null)
          return;
        rowDeletingEvent((object) this, new bit3444_dataset.tblFlightsRowChangeEvent((bit3444_dataset.tblFlightsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void RemovetblFlightsRow(bit3444_dataset.tblFlightsRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType1 = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        bit3444_dataset bit3444Dataset = new bit3444_dataset();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        schemaComplexType1.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = bit3444Dataset.Namespace
        });
        schemaComplexType1.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (tblFlightsDataTable)
        });
        schemaComplexType1.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = bit3444Dataset.GetSchemaSerializable();
        XmlSchemaComplexType schemaComplexType2;
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              MemoryStream memoryStream3 = memoryStream2;
              current.Write((Stream) memoryStream3);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                {
                  schemaComplexType2 = schemaComplexType1;
                  goto label_15;
                }
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        schemaComplexType2 = schemaComplexType1;
label_15:
        return schemaComplexType2;
      }
    }

    public class tblAirportsRow : DataRow
    {
      private bit3444_dataset.tblAirportsDataTable tabletblAirports;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal tblAirportsRow(DataRowBuilder rb)
        : base(rb)
        => this.tabletblAirports = (bit3444_dataset.tblAirportsDataTable) this.Table;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Code
      {
        get => Conversions.ToString(this[this.tabletblAirports.CodeColumn]);
        set => this[this.tabletblAirports.CodeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string City
      {
        get => Conversions.ToString(this[this.tabletblAirports.CityColumn]);
        set => this[this.tabletblAirports.CityColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string State
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tabletblAirports.StateColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("The value for column 'State' in table 'tblAirports' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tabletblAirports.StateColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Name
      {
        get => Conversions.ToString(this[this.tabletblAirports.NameColumn]);
        set => this[this.tabletblAirports.NameColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool Active
      {
        get
        {
          try
          {
            return Conversions.ToBoolean(this[this.tabletblAirports.ActiveColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("The value for column 'Active' in table 'tblAirports' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tabletblAirports.ActiveColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string Lat
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tabletblAirports.LatColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("The value for column 'Lat' in table 'tblAirports' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tabletblAirports.LatColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string _Long
      {
        get
        {
          try
          {
            return Conversions.ToString(this[this.tabletblAirports.LongColumn]);
          }
          catch (InvalidCastException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            throw new StrongTypingException("The value for column 'Long' in table 'tblAirports' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tabletblAirports.LongColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsStateNull() => this.IsNull(this.tabletblAirports.StateColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetStateNull() => this[this.tabletblAirports.StateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsActiveNull() => this.IsNull(this.tabletblAirports.ActiveColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetActiveNull() => this[this.tabletblAirports.ActiveColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool IsLatNull() => this.IsNull(this.tabletblAirports.LatColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void SetLatNull() => this[this.tabletblAirports.LatColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool Is_LongNull() => this.IsNull(this.tabletblAirports.LongColumn);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public void Set_LongNull() => this[this.tabletblAirports.LongColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bit3444_dataset.tblFlightsRow[] GettblFlightsRowsByFK_tblFlights_tblAirports() => this.Table.ChildRelations["FK_tblFlights_tblAirports"] != null ? (bit3444_dataset.tblFlightsRow[]) this.GetChildRows(this.Table.ChildRelations["FK_tblFlights_tblAirports"]) : new bit3444_dataset.tblFlightsRow[0];

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bit3444_dataset.tblFlightsRow[] GettblFlightsRowsByFK_tblFlights_tblAirports1() => this.Table.ChildRelations["FK_tblFlights_tblAirports1"] != null ? (bit3444_dataset.tblFlightsRow[]) this.GetChildRows(this.Table.ChildRelations["FK_tblFlights_tblAirports1"]) : new bit3444_dataset.tblFlightsRow[0];
    }

    public class tblFlightsRow : DataRow
    {
      private bit3444_dataset.tblFlightsDataTable tabletblFlights;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      internal tblFlightsRow(DataRowBuilder rb)
        : base(rb)
        => this.tabletblFlights = (bit3444_dataset.tblFlightsDataTable) this.Table;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public int flightID
      {
        get => Conversions.ToInteger(this[this.tabletblFlights.flightIDColumn]);
        set => this[this.tabletblFlights.flightIDColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string departFROM
      {
        get => Conversions.ToString(this[this.tabletblFlights.departFROMColumn]);
        set => this[this.tabletblFlights.departFROMColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public string arriveAT
      {
        get => Conversions.ToString(this[this.tabletblFlights.arriveATColumn]);
        set => this[this.tabletblFlights.arriveATColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public Decimal distance
      {
        get => Conversions.ToDecimal(this[this.tabletblFlights.distanceColumn]);
        set => this[this.tabletblFlights.distanceColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bool active
      {
        get => Conversions.ToBoolean(this[this.tabletblFlights.activeColumn]);
        set => this[this.tabletblFlights.activeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bit3444_dataset.tblAirportsRow tblAirportsRowByFK_tblFlights_tblAirports
      {
        get => (bit3444_dataset.tblAirportsRow) this.GetParentRow(this.Table.ParentRelations["FK_tblFlights_tblAirports"]);
        set => this.SetParentRow((DataRow) value, this.Table.ParentRelations["FK_tblFlights_tblAirports"]);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bit3444_dataset.tblAirportsRow tblAirportsRowByFK_tblFlights_tblAirports1
      {
        get => (bit3444_dataset.tblAirportsRow) this.GetParentRow(this.Table.ParentRelations["FK_tblFlights_tblAirports1"]);
        set => this.SetParentRow((DataRow) value, this.Table.ParentRelations["FK_tblFlights_tblAirports1"]);
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class tblAirportsRowChangeEvent : EventArgs
    {
      private bit3444_dataset.tblAirportsRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public tblAirportsRowChangeEvent(bit3444_dataset.tblAirportsRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bit3444_dataset.tblAirportsRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
    public class tblFlightsRowChangeEvent : EventArgs
    {
      private bit3444_dataset.tblFlightsRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public tblFlightsRowChangeEvent(bit3444_dataset.tblFlightsRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public bit3444_dataset.tblFlightsRow Row => this.eventRow;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
      public DataRowAction Action => this.eventAction;
    }
  }
}
