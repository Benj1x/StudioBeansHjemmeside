using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCStudioBeansWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Projects()
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
        public ActionResult Games()
        {

            return View();
        }

        public ActionResult Programs()
        {

            return View();
        }
        public ActionResult ContactConsent()
        {
            return View();
        }
    }
}