using System;
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
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Having trouble?, Send us a message";

            return View();
        }

        public ActionResult Foo() {

            return View("About");
        }

        [HttpPost]
        public ActionResult Contact(string message) 
        {
            //TODO: Send message to HQ
            ViewBag.TheMessage = "Thanks we got your message";

            return View();
        }


        public ActionResult Serial(string LetterCase) {

            var SerialNumber = "ASPNETMVCATM1";
            if (LetterCase == "lower")
            {
                return Content (SerialNumber.ToLower());
            }
            else {
                return Json(new {name="Serial", value=SerialNumber }, JsonRequestBehavior.AllowGet);
            }
            

        }
    }
}