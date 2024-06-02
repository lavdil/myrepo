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
    public class MaintenanceRecordsController : Controller
    {
        private dbEntities db = new dbEntities();

        // GET: MaintenanceRecords
        public ActionResult Index()
        {
            var maintenanceRecords = db.MaintenanceRecords.Include(m => m.Bus);
            return View(maintenanceRecords.ToList());
        }

        // GET: MaintenanceRecords/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaintenanceRecord maintenanceRecord = db.MaintenanceRecords.Find(id);
            if (maintenanceRecord == null)
            {
                return HttpNotFound();
            }
            return View(maintenanceRecord);
        }

        // GET: MaintenanceRecords/Create
        public ActionResult Create()
        {
            ViewBag.BusID = new SelectList(db.Buses, "BusID", "BusNumber");
            return View();
        }

        // POST: MaintenanceRecords/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaintenanceID,FormattedID,BusID,MaintenanceDate,Description,Cost,ServiceCenter,NextScheduledMaintenance")] MaintenanceRecord maintenanceRecord)
        {
            if (ModelState.IsValid)
            {
                db.MaintenanceRecords.Add(maintenanceRecord);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BusID = new SelectList(db.Buses, "BusID", "BusNumber", maintenanceRecord.BusID);
            return View(maintenanceRecord);
        }

        // GET: MaintenanceRecords/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaintenanceRecord maintenanceRecord = db.MaintenanceRecords.Find(id);
            if (maintenanceRecord == null)
            {
                return HttpNotFound();
            }
            ViewBag.BusID = new SelectList(db.Buses, "BusID", "BusNumber", maintenanceRecord.BusID);
            return View(maintenanceRecord);
        }

        // POST: MaintenanceRecords/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaintenanceID,FormattedID,BusID,MaintenanceDate,Description,Cost,ServiceCenter,NextScheduledMaintenance")] MaintenanceRecord maintenanceRecord)
        {
            if (ModelState.IsValid)
            {
                db.Entry(maintenanceRecord).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BusID = new SelectList(db.Buses, "BusID", "BusNumber", maintenanceRecord.BusID);
            return View(maintenanceRecord);
        }

        // GET: MaintenanceRecords/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaintenanceRecord maintenanceRecord = db.MaintenanceRecords.Find(id);
            if (maintenanceRecord == null)
            {
                return HttpNotFound();
            }
            return View(maintenanceRecord);
        }

        // POST: MaintenanceRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MaintenanceRecord maintenanceRecord = db.MaintenanceRecords.Find(id);
            db.MaintenanceRecords.Remove(maintenanceRecord);
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
