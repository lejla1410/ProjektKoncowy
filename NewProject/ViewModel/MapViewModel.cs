using NewProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewProject.ViewModel
{
    public class MapViewModel
    {
        public IEnumerable<MapsDB> Markery { get; set; }

        public MapViewModel(IEnumerable<MapsDB> markery)
        {
            Markery = markery;
        }
    }
}