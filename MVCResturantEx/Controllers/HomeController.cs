using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCResturantEx2.data;
using MVCResturantEx2.data.Service;

namespace MVCResturantEx.Controllers
{
    public class HomeController : Controller
    {
        public SqlRestaurantData simDB;

        public HomeController(SqlRestaurantData simDB)
        {
            this.simDB = simDB;
        }
        public ActionResult Projects()
        {
            //var model = simDB.getAll();
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

        public ActionResult Details(int id)
        {
            var model = simDB.getDetails(id);
            if (model == null)
            {
                return View("Projects");
            }
            return View(model);
        }

    }
}