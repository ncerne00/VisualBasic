// Decompiled with JetBrains decompiler
// Type: LINQ.bit3444_airports
// Assembly: LINQ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ADC7924A-8176-4616-8423-22FB7B9F821F
// Assembly location: C:\Users\Nick\Downloads\LINQ.exe

using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace LINQ
{
  public class bit3444_airports : DbContext
  {
    public bit3444_airports() => this.\u002Ector("name=bit3444_airports");

    protected virtual void OnModelCreating(DbModelBuilder modelBuilder) => throw new UnintentionalCodeFirstException();

    public virtual DbSet<tblAirport> tblAirports { get; set; }

    public virtual DbSet<tblFlight> tblFlights { get; set; }

    public virtual DbSet<LINQ.vwActiveFlights2> vwActiveFlights2 { get; set; }
  }
}
