using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using naideno.kg.Models;
using naideno.kg.Context;

namespace naideno.kg.Controllers
{
    public class addingadvertController : Controller
    {
        public EFDbContext db = new EFDbContext(); 
        // GET: addingadvert
        public ActionResult Index()
        {
            return View();
        }
       
        [HttpGet]
        public ActionResult adddocument()
        {
            return PartialView();
        }
        public ActionResult adduniversal()
        {
            return PartialView();
        }
        [HttpPost]
        public string adduniversal(Universal thing)
        {
            //здесь поиск соответствия
            db.Universals.Add(thing);
            db.SaveChanges();
            return "лоль";
        }
        public string adddocument(Passport pass)
        {
            //здесь поиск соотвествия
            db.Passports.Add(pass);
            db.SaveChanges();
            return "лоль";
        }
    }
}