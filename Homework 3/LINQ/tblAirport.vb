'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class tblAirport
    Public Property Code As String
    Public Property City As String
    Public Property State As String
    Public Property Name As String
    Public Property Active As Nullable(Of Boolean)
    Public Property Lat As String
    Public Property [Long] As String

    Public Overridable Property tblFlights As ICollection(Of tblFlight) = New HashSet(Of tblFlight)
    Public Overridable Property tblFlights1 As ICollection(Of tblFlight) = New HashSet(Of tblFlight)

End Class
