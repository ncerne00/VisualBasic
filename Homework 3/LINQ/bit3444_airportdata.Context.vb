﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class bit3444_airports
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=bit3444_airports")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property tblAirports() As DbSet(Of tblAirport)
    Public Overridable Property tblFlights() As DbSet(Of tblFlight)
    Public Overridable Property vwActiveFlights2() As DbSet(Of vwActiveFlights2)

End Class
