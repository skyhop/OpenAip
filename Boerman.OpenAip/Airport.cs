using System;
using System.Collections.Generic;
using System.Text;
using NetTopologySuite.Geometries;

namespace Boerman.OpenAip
{
    public class Airport
    {
        public string Country { get; set; }

        public string Name { get; set; }

        public string ICAO { get; set; }

        public Point Location { get; set; }

        public Radio[] Radios { get; set; }

        public Runway[] Runways { get; set; }

        public AirportType Type { get; set; }
    }
}
