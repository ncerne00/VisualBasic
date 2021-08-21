// Decompiled with JetBrains decompiler
// Type: LINQ.frmFlight
// Assembly: LINQ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ADC7924A-8176-4616-8423-22FB7B9F821F
// Assembly location: C:\Users\Nick\Downloads\LINQ.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace LINQ
{
  [DesignerGenerated]
  public class frmFlight : Form
  {
    private IContainer components;
    private tblAirport orig;
    private bit3444_airports db;

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
      this.lstbFlights = new ListBox();
      this.lblDepart = new Label();
      this.lblDepartValue = new Label();
      this.lblArriveValue = new Label();
      this.lblArrive = new Label();
      this.lblDistanceValue = new Label();
      this.lblDistance = new Label();
      this.lblAirport = new Label();
      this.btnClose = new Button();
      this.SuspendLayout();
      this.lstbFlights.FormattingEnabled = true;
      this.lstbFlights.Location = new Point(12, 64);
      this.lstbFlights.Name = "lstbFlights";
      this.lstbFlights.Size = new Size(150, 186);
      this.lstbFlights.TabIndex = 0;
      this.lblDepart.AutoSize = true;
      this.lblDepart.Font = new Font("Trebuchet MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblDepart.Location = new Point(168, 64);
      this.lblDepart.Name = "lblDepart";
      this.lblDepart.Size = new Size(99, 22);
      this.lblDepart.TabIndex = 1;
      this.lblDepart.Text = "Depart From";
      this.lblDepartValue.AutoSize = true;
      this.lblDepartValue.Font = new Font("Trebuchet MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblDepartValue.Location = new Point(273, 64);
      this.lblDepartValue.Name = "lblDepartValue";
      this.lblDepartValue.Size = new Size(0, 22);
      this.lblDepartValue.TabIndex = 2;
      this.lblArriveValue.AutoSize = true;
      this.lblArriveValue.Font = new Font("Trebuchet MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblArriveValue.Location = new Point(273, 97);
      this.lblArriveValue.Name = "lblArriveValue";
      this.lblArriveValue.Size = new Size(0, 22);
      this.lblArriveValue.TabIndex = 4;
      this.lblArrive.AutoSize = true;
      this.lblArrive.Font = new Font("Trebuchet MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblArrive.Location = new Point(168, 97);
      this.lblArrive.Name = "lblArrive";
      this.lblArrive.Size = new Size(73, 22);
      this.lblArrive.TabIndex = 3;
      this.lblArrive.Text = "Arrive At";
      this.lblDistanceValue.AutoSize = true;
      this.lblDistanceValue.Font = new Font("Trebuchet MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblDistanceValue.Location = new Point(273, 132);
      this.lblDistanceValue.Name = "lblDistanceValue";
      this.lblDistanceValue.Size = new Size(0, 22);
      this.lblDistanceValue.TabIndex = 6;
      this.lblDistance.AutoSize = true;
      this.lblDistance.Font = new Font("Trebuchet MS", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblDistance.Location = new Point(168, 132);
      this.lblDistance.Name = "lblDistance";
      this.lblDistance.Size = new Size(70, 22);
      this.lblDistance.TabIndex = 5;
      this.lblDistance.Text = "Distance";
      this.lblAirport.AutoSize = true;
      this.lblAirport.Font = new Font("Trebuchet MS", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblAirport.Location = new Point(12, 9);
      this.lblAirport.Name = "lblAirport";
      this.lblAirport.Size = new Size(79, 27);
      this.lblAirport.TabIndex = 7;
      this.lblAirport.Text = "Airport";
      this.btnClose.Location = new Point(458, 238);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(103, 30);
      this.btnClose.TabIndex = 8;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(590, 280);
      this.Controls.Add((Control) this.btnClose);
      this.Controls.Add((Control) this.lblAirport);
      this.Controls.Add((Control) this.lblDistanceValue);
      this.Controls.Add((Control) this.lblDistance);
      this.Controls.Add((Control) this.lblArriveValue);
      this.Controls.Add((Control) this.lblArrive);
      this.Controls.Add((Control) this.lblDepartValue);
      this.Controls.Add((Control) this.lblDepart);
      this.Controls.Add((Control) this.lstbFlights);
      this.Name = nameof (frmFlight);
      this.Text = "Flights for CODE";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual ListBox lstbFlights
    {
      get => this._lstbFlights;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lstbFlights_SelectedIndexChanged);
        ListBox lstbFlights1 = this._lstbFlights;
        if (lstbFlights1 != null)
          lstbFlights1.SelectedIndexChanged -= eventHandler;
        this._lstbFlights = value;
        ListBox lstbFlights2 = this._lstbFlights;
        if (lstbFlights2 == null)
          return;
        lstbFlights2.SelectedIndexChanged += eventHandler;
      }
    }

    [field: AccessedThroughProperty("lblDepart")]
    internal virtual Label lblDepart { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblDepartValue")]
    internal virtual Label lblDepartValue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblArriveValue")]
    internal virtual Label lblArriveValue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblArrive")]
    internal virtual Label lblArrive { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblDistanceValue")]
    internal virtual Label lblDistanceValue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblDistance")]
    internal virtual Label lblDistance { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("lblAirport")]
    internal virtual Label lblAirport { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button btnClose
    {
      get => this._btnClose;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnClose_Click);
        Button btnClose1 = this._btnClose;
        if (btnClose1 != null)
          btnClose1.Click -= eventHandler;
        this._btnClose = value;
        Button btnClose2 = this._btnClose;
        if (btnClose2 == null)
          return;
        btnClose2.Click += eventHandler;
      }
    }

    public frmFlight(string orgAirport)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      frmFlight._Closure\u0024__41\u002D0 closure410 = new frmFlight._Closure\u0024__41\u002D0();
      // ISSUE: reference to a compiler-generated field
      closure410.\u0024VB\u0024Local_orgAirport = orgAirport;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Shown += new EventHandler(this.frmFlight_Shown);
      this.db = new bit3444_airports();
      this.InitializeComponent();
      ParameterExpression parameterExpression;
      // ISSUE: reference to a compiler-generated field
      this.orig = ((IQueryable<tblAirport>) this.db.tblAirports).Where<tblAirport>(Expression.Lambda<Func<tblAirport, bool>>((Expression) Expression.Equal(Operators.CompareString(airport.Code, closure410.\u0024VB\u0024Local_orgAirport, false), 0, false, (MethodInfo) null), parameterExpression)).Single<tblAirport>();
      this.Text = "Flights FROM " + this.orig.Code + " - " + this.orig.City;
      this.lblAirport.Text = this.orig.Code + " - " + this.orig.City;
    }

    private void frmFlight_Shown(object sender, EventArgs e)
    {
      ParameterExpression parameterExpression;
      List<vwActiveFlights2> list = ((IQueryable<vwActiveFlights2>) this.db.vwActiveFlights2).Where<vwActiveFlights2>(Expression.Lambda<Func<vwActiveFlights2, bool>>((Expression) Expression.Equal(Operators.CompareString(flights.departFROM, this.orig.Code, false), 0, false, (MethodInfo) null), parameterExpression)).ToList<vwActiveFlights2>();
      try
      {
        foreach (vwActiveFlights2 vwActiveFlights2 in list)
          this.lstbFlights.Items.Add((object) vwActiveFlights2.arriveAT);
      }
      finally
      {
        List<vwActiveFlights2>.Enumerator enumerator;
        enumerator.Dispose();
      }
      if (list.Count != 0)
        return;
      this.lstbFlights.Items.Add((object) "No active flights...");
      this.lstbFlights.Enabled = false;
    }

    private void lstbFlights_SelectedIndexChanged(object sender, EventArgs e)
    {
      ParameterExpression parameterExpression;
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: method reference
      vwActiveFlights2 vwActiveFlights2 = ((IQueryable<vwActiveFlights2>) this.db.vwActiveFlights2).Where<vwActiveFlights2>(Expression.Lambda<Func<vwActiveFlights2, bool>>((Expression) Expression.And((Expression) Expression.Equal(Operators.CompareString(flight.arriveAT, this.lstbFlights.SelectedItem.ToString(), false), 0, false, (MethodInfo) null), (Expression) Expression.Equal((Expression) Expression.Call((Expression) null, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Operators.CompareString)), new Expression[3]
      {
        (Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vwActiveFlights2.get_departFROM))),
        (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) this, typeof (frmFlight)), FieldInfo.GetFieldFromHandle(__fieldref (frmFlight.orig))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (tblAirport.get_Code))),
        (Expression) Expression.Constant((object) false, typeof (bool))
      }), (Expression) Expression.Constant((object) 0, typeof (int)), false, (MethodInfo) null)), parameterExpression)).SingleOrDefault<vwActiveFlights2>();
      this.lblDepartValue.Text = vwActiveFlights2.departFROM + " - " + this.getAirportCity(vwActiveFlights2.departFROM);
      this.lblArriveValue.Text = vwActiveFlights2.arriveAT + " - " + this.getAirportCity(vwActiveFlights2.arriveAT);
      Decimal? distance;
      this.lblDistanceValue.Text = ((distance = vwActiveFlights2.Distance).HasValue ? Conversions.ToString(distance.GetValueOrDefault()) : (string) null) + " miles";
    }

    private string getAirportCity(string code)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      frmFlight._Closure\u0024__44\u002D0 closure440 = new frmFlight._Closure\u0024__44\u002D0();
      // ISSUE: reference to a compiler-generated field
      closure440.\u0024VB\u0024Local_code = code;
      ParameterExpression parameterExpression;
      // ISSUE: reference to a compiler-generated field
      return ((IQueryable<tblAirport>) this.db.tblAirports).Where<tblAirport>(Expression.Lambda<Func<tblAirport, bool>>((Expression) Expression.Equal(Operators.CompareString(airports.Code, closure440.\u0024VB\u0024Local_code, false), 0, false, (MethodInfo) null), parameterExpression)).Select<tblAirport, string>((Expression<Func<tblAirport, string>>) (airports => airports.City)).Single<string>();
    }

    private void btnClose_Click(object sender, EventArgs e) => this.Close();
  }
}
