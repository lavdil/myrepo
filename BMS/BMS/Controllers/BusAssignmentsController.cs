using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BMS.Controllers
{
    public class BusAssignmentsController : Controller
    {
        private dbEntities db = new dbEntities();

        // GET: BusAssignments
        public ActionResult Index()
        {
            var busAssignments = db.BusAssignments.Include(b => b.Bus).Include(b => b.Driver);
            return View(busAssignments.ToList());
        }

        // GET: BusAssignments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusAssignment busAssignment = db.BusAssignments.Find(id);
            if (busAssignment == null)
            {
                return HttpNotFound();
            }
            return View(busAssignment);
        }

        // GET: BusAssignments/Create
        public ActionResult Create()
        {
            ViewBag.BusID = new SelectList(db.Buses, "BusID", "BusNumber");
            ViewBag.DriverID = new SelectList(db.Drivers, "DriverID", "Name");
            return View();
        }

        // POST: BusAssignments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AssignmentID,BusID,DriverID,AssignmentDate,Shift")] BusAssignment busAssignment)
        {
            if (ModelState.IsValid)
            {
                db.BusAssignments.Add(busAssignment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BusID = new SelectList(db.Buses, "BusID", "BusNumber", busAssignment.BusID);
            ViewBag.DriverID = new SelectList(db.Drivers, "DriverID", "Name", busAssignment.DriverID);
            return View(busAssignment);
        }

        // GET: BusAssignments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusAssignment busAssignment = db.BusAssignments.Find(id);
            if (busAssignment == null)
            {
                return HttpNotFound();
            }
            ViewBag.BusID = new SelectList(db.Buses, "BusID", "BusNumber", busAssignment.BusID);
            ViewBag.DriverID = new SelectList(db.Drivers, "DriverID", "Name", busAssignment.DriverID);
            return View(busAssignment);
        }

        // POST: BusAssignments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AssignmentID,BusID,DriverID,AssignmentDate,Shift")] BusAssignment busAssignment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(busAssignment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BusID = new SelectList(db.Buses, "BusID", "BusNumber", busAssignment.BusID);
            ViewBag.DriverID = new SelectList(db.Drivers, "DriverID", "Name", busAssignment.DriverID);
            return View(busAssignment);
        }

        // GET: BusAssignments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusAssignment busAssignment = db.BusAssignments.Find(id);
            if (busAssignment == null)
            {
                return HttpNotFound();
            }
            return View(busAssignment);
        }

        // POST: BusAssignments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BusAssignment busAssignment = db.BusAssignments.Find(id);
            db.BusAssignments.Remove(busAssignment);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
