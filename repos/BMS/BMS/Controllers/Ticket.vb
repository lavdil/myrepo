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

Partial Public Class Ticket
    Public Property TicketID As Integer
    Public Property ScheduleID As Nullable(Of Integer)
    Public Property PassengerName As String
    Public Property SeatNumber As Nullable(Of Integer)
    Public Property BookingDate As Nullable(Of Date)
    Public Property Fare As Nullable(Of Decimal)
    Public Property TicketStatus As String

    Public Overridable Property Payments As ICollection(Of Payment) = New HashSet(Of Payment)
    Public Overridable Property Schedule As Schedule

End Class
