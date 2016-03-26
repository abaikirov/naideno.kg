using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace naideno.kg.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
    }
}