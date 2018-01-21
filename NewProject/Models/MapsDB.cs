using System;
using System.Collections.Generic;


namespace NewProject.Models
{

    public class MapsDB
    {
        public int ID { get; set; }
        public string AtractionName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string City { get; set; }
    }
}
