﻿using NewProject.Models;
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
        private MapsDbContext db = new MapsDbContext();

        public ActionResult MapView()
        {
            var markeryZbazdy = db.MapsDB.ToList().Where(m => m.City.Equals("Gdynia"));

            var markery = new List<MapsDB>
            {
             new MapsDB()
             {
                 AtractionName = "Muzeum Emigracji",
                 ID=8,
                 Latitude=54.5331021,
                 Longitude = 18.54793821,
                 City = "Gdynia"
             }
            };

            return View(new MapViewModel(markery));
        }
    }
}