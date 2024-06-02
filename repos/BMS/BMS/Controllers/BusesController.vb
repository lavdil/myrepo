Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports BMS

Namespace Controllers
    Public Class BusesController
        Inherits System.Web.Mvc.Controller

        Private db As New dbEntities

        ' GET: Buses
        Function Index() As ActionResult
            Return View(db.Buses.ToList())
        End Function

        ' GET: Buses/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim bus As Bus = db.Buses.Find(id)
            If IsNothing(bus) Then
                Return HttpNotFound()
            End If
            Return View(bus)
        End Function

        ' GET: Buses/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Buses/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="BusID,BusNumber,BusModel,Capacity,PurchaseDate,Status,MaintenanceSchedule")> ByVal bus As Bus) As ActionResult
            If ModelState.IsValid Then
                db.Buses.Add(bus)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(bus)
        End Function

        ' GET: Buses/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim bus As Bus = db.Buses.Find(id)
            If IsNothing(bus) Then
                Return HttpNotFound()
            End If
            Return View(bus)
        End Function

        ' POST: Buses/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="BusID,BusNumber,BusModel,Capacity,PurchaseDate,Status,MaintenanceSchedule")> ByVal bus As Bus) As ActionResult
            If ModelState.IsValid Then
                db.Entry(bus).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(bus)
        End Function

        ' GET: Buses/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim bus As Bus = db.Buses.Find(id)
            If IsNothing(bus) Then
                Return HttpNotFound()
            End If
            Return View(bus)
        End Function

        ' POST: Buses/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim bus As Bus = db.Buses.Find(id)
            db.Buses.Remove(bus)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
