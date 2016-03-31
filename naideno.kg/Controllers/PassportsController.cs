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
using naideno.kg.Core;

namespace naideno.kg.Controllers
{

    [Authorize]
    public class PassportsController : Controller
    {
        private EFDbContext db = new EFDbContext();

        // GET: Passports
        public ActionResult Index()
        {
            return View(db.Passports.ToList());
        }

        // GET: Passports/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passport passport = db.Passports.Find(id);
            if (passport == null)
            {
                return HttpNotFound();
            }
            return View(passport);
        }

        // GET: Passports/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Passports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,SecondName,ThirdName,Birthday,UploadDate,Category,Status,UserID")] Passport passport)
        {
            if (ModelState.IsValid)
            {

                Match match = new Match();

                int matchID = match.PassMatch(passport.Name, passport.SecondName, passport.ThirdName, passport.Birthday, passport.Category);
                if (matchID == 7) return RedirectToAction("Create");
                if (matchID == 0) return RedirectToAction("Details");

                passport.UploadDate = DateTime.Now;
                passport.UserID = db.Users.First(u => u.Name == "buronahodok").ID;

                db.Passports.Add(passport);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(passport);
        }

        // GET: Passports/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passport passport = db.Passports.Find(id);
            if (passport == null)
            {
                return HttpNotFound();
            }
            return View(passport);
        }

        // POST: Passports/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,SecondName,ThirdName,Birthday,UploadDate,Category,Status,UserID")] Passport passport)
        {
            if (ModelState.IsValid)
            {
                db.Entry(passport).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(passport);
        }

        // GET: Passports/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passport passport = db.Passports.Find(id);
            if (passport == null)
            {
                return HttpNotFound();
            }
            return View(passport);
        }

        // POST: Passports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Passport passport = db.Passports.Find(id);
            db.Passports.Remove(passport);
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
