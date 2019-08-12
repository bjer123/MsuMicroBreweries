﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroBreweries
{
    class MicroBrewery
    {
        public string Description { get; set; }
        public int ID { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string Openinghours { get; set; }

        public MicroBrewery(string Description, int ID, double Latitude, double Longitude, string Location, string Name, string Openinghours)
        {
            this.Description = Description;
            this.ID = ID;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            this.Location = Location;
            this.Name = Name;
            this.Openinghours = Openinghours;
        }
    }
}
