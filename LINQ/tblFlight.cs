// Decompiled with JetBrains decompiler
// Type: LINQ.tblFlight
// Assembly: LINQ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ADC7924A-8176-4616-8423-22FB7B9F821F
// Assembly location: C:\Users\Nick\Downloads\LINQ.exe

using System;

namespace LINQ
{
  public class tblFlight
  {
    public int flightID { get; set; }

    public string departFROM { get; set; }

    public string arriveAT { get; set; }

    public Decimal distance { get; set; }

    public bool active { get; set; }

    public virtual tblAirport tblAirport { get; set; }

    public virtual tblAirport tblAirport1 { get; set; }
  }
}
