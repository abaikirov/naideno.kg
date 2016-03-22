using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using naideno.kg.Models;
using naideno.kg.Context;

namespace naideno.kg.Controllers
{
    public class lostfound : Controller
    {
        EFDbContext db = new EFDbContext();
        // GET: lostfound
        public ActionResult Index()
        {
            return View();
        }
    }
}