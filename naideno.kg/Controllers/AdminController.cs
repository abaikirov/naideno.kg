using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using naideno.kg.Models;
using System.Web.Security;

namespace naideno.kg.Controllers
{
    public class AdminController : Controller
    {
        private bool Authenticate (string name, string password)
        {
            bool result = FormsAuthentication.Authenticate(name, password);
            if (result)
                FormsAuthentication.SetAuthCookie(name, false);  
            return result;
        }

        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login( AdminModel model, string returnUrl )
        {
            if (ModelState.IsValid)
            {
                if (Authenticate(model.Name, model.Password))
                {
                    return Redirect(returnUrl ?? Url.Action("Index", "Admin"));
                }
                else
                {
                    ModelState.AddModelError("", "Неправильный логин или пароль");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return View();
        }
    }
}