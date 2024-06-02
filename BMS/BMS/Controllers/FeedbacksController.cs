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
    public class FeedbacksController : Controller
    {
        private dbEntities db = new dbEntities();

        // GET: Feedbacks
        public ActionResult Index()
        {
            var feedbacks = db.Feedbacks.Include(f => f.Bus).Include(f => f.Passenger).Include(f => f.Route);
            return View(feedbacks.ToList());
        }

        // GET: Feedbacks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Feedback feedback = db.Feedbacks.Find(id);
            if (feedback == null)
            {
                return HttpNotFound();
            }
            return View(feedback);
        }

        // GET: Feedbacks/Create
        public ActionResult Create()
        {
            ViewBag.BusID = new SelectList(db.Buses, "BusID", "BusNumber");
            ViewBag.PassengerID = new SelectList(db.Passengers, "PassengerID", "Name");
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteName");
            return View();
        }

        // POST: Feedbacks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FeedbackID,PassengerID,BusID,RouteID,FeedbackDate,Comments,Rating")] Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                db.Feedbacks.Add(feedback);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BusID = new SelectList(db.Buses, "BusID", "BusNumber", feedback.BusID);
            ViewBag.PassengerID = new SelectList(db.Passengers, "PassengerID", "Name", feedback.PassengerID);
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteName", feedback.RouteID);
            return View(feedback);
        }

        // GET: Feedbacks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Feedback feedback = db.Feedbacks.Find(id);
            if (feedback == null)
            {
                return HttpNotFound();
            }
            ViewBag.BusID = new SelectList(db.Buses, "BusID", "BusNumber", feedback.BusID);
            ViewBag.PassengerID = new SelectList(db.Passengers, "PassengerID", "Name", feedback.PassengerID);
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteName", feedback.RouteID);
            return View(feedback);
        }

        // POST: Feedbacks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FeedbackID,PassengerID,BusID,RouteID,FeedbackDate,Comments,Rating")] Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                db.Entry(feedback).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BusID = new SelectList(db.Buses, "BusID", "BusNumber", feedback.BusID);
            ViewBag.PassengerID = new SelectList(db.Passengers, "PassengerID", "Name", feedback.PassengerID);
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteName", feedback.RouteID);
            return View(feedback);
        }

        // GET: Feedbacks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Feedback feedback = db.Feedbacks.Find(id);
            if (feedback == null)
            {
                return HttpNotFound();
            }
            return View(feedback);
        }

        // POST: Feedbacks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Feedback feedback = db.Feedbacks.Find(id);
            db.Feedbacks.Remove(feedback);
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
