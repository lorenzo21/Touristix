﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Touristix.Controllers
{
    public class AccueilController : Controller
    {
        //
        // GET: /Accueil/

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

    }
}
