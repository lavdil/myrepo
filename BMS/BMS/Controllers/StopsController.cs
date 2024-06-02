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
    public class StopsController : Controller
    {
        private dbEntities db = new dbEntities();

        // GET: Stops
        public ActionResult Index()
        {
            var stops = db.Stops.Include(s => s.Route);
            return View(stops.ToList());
        }

        // GET: Stops/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stop stop = db.Stops.Find(id);
            if (stop == null)
            {
                return HttpNotFound();
            }
            return View(stop);
        }

        // GET: Stops/Create
        public ActionResult Create()
        {
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteName");
            return View();
        }

        // POST: Stops/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StopID,RouteID,StopName,Location,ArrivalTime,DepartureTime")] Stop stop)
        {
            if (ModelState.IsValid)
            {
                db.Stops.Add(stop);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteName", stop.RouteID);
            return View(stop);
        }

        // GET: Stops/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stop stop = db.Stops.Find(id);
            if (stop == null)
            {
                return HttpNotFound();
            }
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteName", stop.RouteID);
            return View(stop);
        }

        // POST: Stops/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StopID,RouteID,StopName,Location,ArrivalTime,DepartureTime")] Stop stop)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stop).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteName", stop.RouteID);
            return View(stop);
        }

        // GET: Stops/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stop stop = db.Stops.Find(id);
            if (stop == null)
            {
                return HttpNotFound();
            }
            return View(stop);
        }

        // POST: Stops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Stop stop = db.Stops.Find(id);
            db.Stops.Remove(stop);
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
