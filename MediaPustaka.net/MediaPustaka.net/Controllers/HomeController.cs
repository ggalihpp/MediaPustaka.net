using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaPustaka.net.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Loading()
        {
            ViewBag.Messag = "Thank you, We'll redirecting you to our homepage . . .";

            Response.AddHeader("REFRESH", "3;URL=../Books/Index");
            return View();
        }
    }
}