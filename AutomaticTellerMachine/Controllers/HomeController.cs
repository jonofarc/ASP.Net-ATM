﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomaticTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        //GET /Home/Index
        
        public ActionResult Index()
        {
            return View();
        }

        // GET /Home/About
        public ActionResult About()
        {
            ViewBag.Message = "A web based ATM using ASP.NET ";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.ResponseMessage = "Having trouble?, Send us a message";

            return View();
        }

        public ActionResult Foo() {

            return View("About");
        }

        [HttpPost]
        public ActionResult Contact(string message) 
        {
            //TODO: Send message to HQ
            ViewBag.YourMessage = message;
            ViewBag.ResponseMessage = "Thanks we got your message";

            return View();
        }


        public ActionResult Serial(string LetterCase) {

            var SerialNumber = "ASPNETMVCATM1";
            if (LetterCase == "lower")
            {
                return Content(SerialNumber.ToLower());
            } else if (LetterCase == "upper") {
                return Content(SerialNumber);
            }
            else {
                return Json(new { name = "Serial", value = SerialNumber }, JsonRequestBehavior.AllowGet);
            }
            

        }
    }

   
}