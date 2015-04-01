﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_Tut.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld/
        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        public ActionResult Welcome(string name, int id)
        {

            ViewBag.name = name;
            ViewBag.count = id;

            return View();
        }
    }
}