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
        private MapsEntities db = new MapsEntities();

        public ActionResult MapView()
        {
             MapsDB CityAtraction = new MapsDB
            {
                 AtractionName= "Muzeum Emigracji", 
                 Latitude= 54.5331021, 
                 Longitude= 18.54793821,
                 City = "Gdynia", 
            };

            return View("MapsDB",CityAtraction);
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