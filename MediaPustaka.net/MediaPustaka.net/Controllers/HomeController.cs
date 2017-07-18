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
            ViewBag.Message = "Thank you, We'll redirecting you to our homepage . . .";

            Response.AddHeader("REFRESH", "3;URL=../Books/Index");
            return View();
        }

        public ActionResult PleaseLogin()
        {
            ViewBag.Message = "Please Login To Access This Page . . .";

            Response.AddHeader("REFRESH", "3;URL=../User/Login");
            return View();
        }

        public ActionResult AdminOnly()
        {
            ViewBag.Message = "This is restricted Area . . .";

            Response.AddHeader("REFRESH", "3;URL=../User/Login");
            return View();
        }
    }
}