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

Partial Public Class tblProject
    Public Property projectid As Integer
    Public Property companyName As String
    Public Property industry As String
    Public Property projectRevenue As Nullable(Of Decimal)

    Public Overridable Property tblProjectHours As ICollection(Of tblProjectHour) = New HashSet(Of tblProjectHour)
    Public Overridable Property tblStaffRates As ICollection(Of tblStaffRate) = New HashSet(Of tblStaffRate)

End Class
