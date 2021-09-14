using System.Text.RegularExpressions;
using System.Linq;
using System;

namespace LoggingKata

{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();

        public double ShouldParseLongitude(string line) => throw new System.NotImplementedException();

        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            #region Instructions Part 1           Capture 1                 Capture 2           Capture 3
            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            //var cells = line.Split(',');

            //// If your array.Length is less than 3, something went wrong
            //if (cells.Length < 3)
            //{
            //    // Log that and return null
            //    // Do not fail if one record parsing fails, return null
            //    return null; // TODO Implement <-- That might already be implemented?
            //}            
            // "34.073638, -84.677017, Taco Bell Acwort..."
            #endregion               
            var csvData = new Regex(@"(-?[\d]+\.[\d]+?), ?(-?[\d]+\.[\d]+), ?(.+)").Match(line).Groups.Values.Select(x => x.ToString()).ToArray();
            #region Instructions Part 2
            // grab the latitude from your array at index 0

            // grab the longitude from your array at index 1

            // grab the name from your array at index 2           

            // Your going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`

            // You'll need to create a TacoBell class
            // that conforms to ITrackable

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly

            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable
            #endregion
            return new TacoBell(Double.Parse(csvData[0]), Double.Parse(csvData[1]), csvData[2]);
        }
    }
}