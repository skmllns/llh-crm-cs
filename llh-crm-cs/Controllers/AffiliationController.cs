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
    public class AffiliationController : Controller
    {
        private CRMContext db = new CRMContext();

        // GET: /Affiliation/
        public ActionResult Index()
        {
            return View(db.Affiliations.ToList());
        }

        // GET: /Affiliation/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Affiliation affiliation = db.Affiliations.Find(id);
            if (affiliation == null)
            {
                return HttpNotFound();
            }
            return View(affiliation);
        }

        // GET: /Affiliation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Affiliation/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="AffiliationID,ConstituentID,EmployerName")] Affiliation affiliation)
        {
            if (ModelState.IsValid)
            {
                db.Affiliations.Add(affiliation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(affiliation);
        }

        // GET: /Affiliation/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Affiliation affiliation = db.Affiliations.Find(id);
            if (affiliation == null)
            {
                return HttpNotFound();
            }
            return View(affiliation);
        }

        // POST: /Affiliation/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="AffiliationID,ConstituentID,EmployerName")] Affiliation affiliation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(affiliation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(affiliation);
        }

        // GET: /Affiliation/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Affiliation affiliation = db.Affiliations.Find(id);
            if (affiliation == null)
            {
                return HttpNotFound();
            }
            return View(affiliation);
        }

        // POST: /Affiliation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Affiliation affiliation = db.Affiliations.Find(id);
            db.Affiliations.Remove(affiliation);
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
