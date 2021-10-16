using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingKata
{
    class TacoBell : ITrackable
    {
        // TacoBell class implements an ITrackable Interface with Name & Location
        public string Name { get; set; }
        
        // Point is a struct that represents a GPS Location with Latitude and Longitude properties
        public Point Location { get; set; }       

        /// <summary>
        /// Constructor will create a TacoBell object with the provided Latitude, Longitude and Name.
        /// </summary>
        public TacoBell(double latitude, double longitude, string name)
        {
            Location = new Point() { Latitude = latitude, Longitude = longitude };
            Name = name;
        }
    }
}
