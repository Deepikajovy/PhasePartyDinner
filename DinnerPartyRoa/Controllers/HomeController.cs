﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DinnerPartyRoa.App_Start;
using DinnerPartyRoa.Models;

namespace DinnerPartyRoa.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DBConfig.RunDbMigrations();
            return View();

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Order()
        {
            OrderData data = new OrderData();

            return View(data.Read());
        }
    }
}