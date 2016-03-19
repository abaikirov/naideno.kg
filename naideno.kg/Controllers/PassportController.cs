using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using naideno.kg.Context;
using System.Web.Mvc;
using naideno.kg.Models;

namespace naideno.kg.Controllers
{
    public class PassportController : Controller
    {
        private EFDbContext db = new EFDbContext();

        public ActionResult Index()
        {
            return View(db.Passports.ToList());
        }
    }
}