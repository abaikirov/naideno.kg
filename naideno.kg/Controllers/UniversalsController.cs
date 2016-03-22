using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using naideno.kg.Context;
using naideno.kg.Models;

namespace naideno.kg.Controllers
{
    public class UniversalsController : Controller
    {
        private EFDbContext db = new EFDbContext();

        // GET: Universals
        public ActionResult Index()
        {
            var universals = db.Universals.Include(u => u.User);
            return View(universals.ToList());
        }

        // GET: Universals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Universal universal = db.Universals.Find(id);
            if (universal == null)
            {
                return HttpNotFound();
            }
            return View(universal);
        }

        // GET: Universals/Create
        public ActionResult Create()
        {
            ViewBag.UserID = new SelectList(db.Users, "ID", "Name");
            return View();
        }

        // POST: Universals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Description,UploadDate,Category,Status,UserID")] Universal universal)
        {
            if (ModelState.IsValid)
            {
                universal.UploadDate = DateTime.Now;
                universal.UserID = db.Users.First(u => u.Name == "buronahodok").ID;

                db.Universals.Add(universal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserID = new SelectList(db.Users, "ID", "Name", universal.UserID);
            return View(universal);
        }

        // GET: Universals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Universal universal = db.Universals.Find(id);
            if (universal == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserID = new SelectList(db.Users, "ID", "Name", universal.UserID);
            return View(universal);
        }

        // POST: Universals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Description,UploadDate,Category,Status,UserID")] Universal universal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(universal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserID = new SelectList(db.Users, "ID", "Name", universal.UserID);
            return View(universal);
        }

        // GET: Universals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Universal universal = db.Universals.Find(id);
            if (universal == null)
            {
                return HttpNotFound();
            }
            return View(universal);
        }

        // POST: Universals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Universal universal = db.Universals.Find(id);
            db.Universals.Remove(universal);
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
