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
    public class ConstituentController : Controller
    {
        private CRMContext db = new CRMContext();

        // GET: /Constituent/
        public ActionResult Index()
        {
            return View(db.Constituents.ToList());
        }

        // GET: /Constituent/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Constituent constituent = db.Constituents.Find(id);
            if (constituent == null)
            {
                return HttpNotFound();
            }
            return View(constituent);
        }

        // GET: /Constituent/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Constituent/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ConstituentID,IsPerson,FirstName,LastName,Address,City,State,ZipCode,Country,Email,PhoneNumber,ReferralMethod,ActiveSince,AgeRange,Notes")] Constituent constituent)
        {
            if (ModelState.IsValid)
            {
                db.Constituents.Add(constituent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(constituent);
        }

        // GET: /Constituent/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Constituent constituent = db.Constituents.Find(id);
            if (constituent == null)
            {
                return HttpNotFound();
            }
            return View(constituent);
        }

        // POST: /Constituent/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ConstituentID,IsPerson,FirstName,LastName,Address,City,State,ZipCode,Country,Email,PhoneNumber,ReferralMethod,ActiveSince,AgeRange,Notes")] Constituent constituent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(constituent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(constituent);
        }

        // GET: /Constituent/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Constituent constituent = db.Constituents.Find(id);
            if (constituent == null)
            {
                return HttpNotFound();
            }
            return View(constituent);
        }

        // POST: /Constituent/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Constituent constituent = db.Constituents.Find(id);
            db.Constituents.Remove(constituent);
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
