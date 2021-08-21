// Decompiled with JetBrains decompiler
// Type: LINQ.tblAirport
// Assembly: LINQ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ADC7924A-8176-4616-8423-22FB7B9F821F
// Assembly location: C:\Users\Nick\Downloads\LINQ.exe

using System.Collections.Generic;

namespace LINQ
{
  public class tblAirport
  {
    public tblAirport()
    {
      this.tblFlights = (ICollection<tblFlight>) new HashSet<tblFlight>();
      this.tblFlights1 = (ICollection<tblFlight>) new HashSet<tblFlight>();
    }

    public string Code { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string Name { get; set; }

    public bool? Active { get; set; }

    public string Lat { get; set; }

    public string Long { get; set; }

    public virtual ICollection<tblFlight> tblFlights { get; set; }

    public virtual ICollection<tblFlight> tblFlights1 { get; set; }
  }
}
