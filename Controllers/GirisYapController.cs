﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelTrip_Project.Controllers
{
    public class GirisYapController : Controller
    {
        // GET: GirisYap
        public ActionResult Login()
        {
            return View();
        }
    }
}