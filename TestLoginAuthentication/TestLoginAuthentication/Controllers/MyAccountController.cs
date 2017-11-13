using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestLoginAuthentication.Models;
using TestLoginAuthentication.DAL;
using System.Web.Security;

namespace TestLoginAuthentication.Controllers
{
    public class MyAccountController : Controller
    {
        //
        // GET: /MyAccount/
        public ActionResult llgin()
        {
            if (Request.IsAuthenticated)
            {
                return RedirectToAction("MyProfile", "Home");

            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult llgin(Login ln)
        {
            using (OfferEntities db = new OfferEntities())
            {
                var user = db.ShopLogin(ln.UserName, ln.Password).FirstOrDefault();
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(user.Name, ln.RememberMe);
                    return RedirectToAction("MyProfile", "Home");
                }
            };
            ModelState.Remove("Password");
            return View();
        }
        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
	}
}