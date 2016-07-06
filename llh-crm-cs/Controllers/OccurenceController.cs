using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using llh_crm_cs.Models;
using llh_crm_cs.DAL;

namespace llh_crm_cs.Controllers
{
    public class OccurenceController : Controller
    {
        private CRMContext db = new CRMContext();

        // GET: /Occurence/
        public ActionResult Index()
        {
            return View(db.Occurences.ToList());
        }

        // GET: /Occurence/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Occurence occurence = db.Occurences.Find(id);
            if (occurence == null)
            {
                return HttpNotFound();
            }
            return View(occurence);
        }

        // GET: /Occurence/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Occurence/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="OccurenceID,OccurenceName,OccurenceCategory,OccurenceDate")] Occurence occurence)
        {
            if (ModelState.IsValid)
            {
                db.Occurences.Add(occurence);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(occurence);
        }

        // GET: /Occurence/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Occurence occurence = db.Occurences.Find(id);
            if (occurence == null)
            {
                return HttpNotFound();
            }
            return View(occurence);
        }

        // POST: /Occurence/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="OccurenceID,OccurenceName,OccurenceCategory,OccurenceDate")] Occurence occurence)
        {
            if (ModelState.IsValid)
            {
                db.Entry(occurence).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(occurence);
        }

        // GET: /Occurence/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Occurence occurence = db.Occurences.Find(id);
            if (occurence == null)
            {
                return HttpNotFound();
            }
            return View(occurence);
        }

        // POST: /Occurence/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Occurence occurence = db.Occurences.Find(id);
            db.Occurences.Remove(occurence);
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
