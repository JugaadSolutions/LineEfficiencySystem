using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LineEfficiencySystem.Models;

namespace LineEfficiencySystem.Controllers
{
    public class StationInputsController : Controller
    {
        private LESContext db = new LESContext();

        // GET: StationInputs
        public ActionResult Index()
        {
            var stationInputs = db.StationInputs.Include(s => s.Operator).Include(s => s.Reference).Include(s => s.Station);
            return View(stationInputs.ToList());
        }

        // GET: StationInputs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StationInput stationInput = db.StationInputs.Find(id);
            if (stationInput == null)
            {
                return HttpNotFound();
            }
            return View(stationInput);
        }

        // GET: StationInputs/Create
        public ActionResult Create()
        {
            ViewBag.OperatorId = new SelectList(db.Operator, "OperatorId", "Code");
            ViewBag.ReferenceId = new SelectList(db.References, "ReferenceId", "Name");
            ViewBag.StationId = new SelectList(db.Stations, "StationId", "Name");
            return View();
        }

        // POST: StationInputs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StationInputId,From,To,ReferenceId,StationId,OperatorId")] StationInput stationInput)
        {
            if (ModelState.IsValid)
            {
                db.StationInputs.Add(stationInput);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.OperatorId = new SelectList(db.Operator, "OperatorId", "Code", stationInput.OperatorId);
            ViewBag.ReferenceId = new SelectList(db.References, "ReferenceId", "Name", stationInput.ReferenceId);
            ViewBag.StationId = new SelectList(db.Stations, "StationId", "Name", stationInput.StationId);
            return View(stationInput);
        }

        // GET: StationInputs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StationInput stationInput = db.StationInputs.Find(id);
            if (stationInput == null)
            {
                return HttpNotFound();
            }
            ViewBag.OperatorId = new SelectList(db.Operator, "OperatorId", "Code", stationInput.OperatorId);
            ViewBag.ReferenceId = new SelectList(db.References, "ReferenceId", "Name", stationInput.ReferenceId);
            ViewBag.StationId = new SelectList(db.Stations, "StationId", "Name", stationInput.StationId);
            return View(stationInput);
        }

        // POST: StationInputs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StationInputId,From,To,ReferenceId,StationId,OperatorId")] StationInput stationInput)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stationInput).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OperatorId = new SelectList(db.Operator, "OperatorId", "Code", stationInput.OperatorId);
            ViewBag.ReferenceId = new SelectList(db.References, "ReferenceId", "Name", stationInput.ReferenceId);
            ViewBag.StationId = new SelectList(db.Stations, "StationId", "Name", stationInput.StationId);
            return View(stationInput);
        }

        // GET: StationInputs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StationInput stationInput = db.StationInputs.Find(id);
            if (stationInput == null)
            {
                return HttpNotFound();
            }
            return View(stationInput);
        }

        // POST: StationInputs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StationInput stationInput = db.StationInputs.Find(id);
            db.StationInputs.Remove(stationInput);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Login(int station)
        {
            ViewBag.Station = station;
            return View();
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
