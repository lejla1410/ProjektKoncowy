using NewProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewProject.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            MapsEntities db = new MapsEntities();
            var CityAtraction = db.MapsDB;
            return View(CityAtraction);
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
    }
}