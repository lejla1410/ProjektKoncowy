using NewProject.Models;
using NewProject.ViewModel;
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
            var markery = new List<MapsDB>
            {
             new MapsDB()
             {
                 // 8, "Muzeum Emigracji", 54.5331021, 18.54793821,"Gdynia"
                 AtractionName = "Muzeum Emigracji",
                 ID=8,
                 Latitude=54.5331021,
                 Longitude = 18.54793821,
                 City = "Gdynia"
             }
            };

            return View(new MapViewModel(markery));
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}