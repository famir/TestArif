﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestLoginAuthentication.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult MyProfile()
        {
            return View();
        }

        public ActionResult TestGit()
        {
            return View();
        }
	}
}