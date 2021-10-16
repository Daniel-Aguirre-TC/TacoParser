using System;
using System.Linq;
using System.IO;
using GeoCoordinatePortable;

namespace LoggingKata
{
    class Program
    {
        // csv file location - this file was stored internally.
        const string csvPath = "TacoBell-US-AL.csv";

        static void Main(string[] args)
        {
            // pull all lines of data from the csv file.
            var lines = File.ReadAllLines(csvPath);
            // Create a new instance of my TacoParser class to parse the csv file
            var parser = new TacoParser();
            // Create an array of TacoBell Locations by using Linq Select to parse each line in lines.
            var locations = lines.Select(parser.Parse).ToList();

            // delcare two locations that I will initialize when I find the farthest locations.
            ITrackable tacoOne = null;
            ITrackable tacoTwo = null;            
            // initialize my distance between locations as 0
            double distance = 0;

            // foreach location in locations initialize a locA variable with the current iterations latitude/longitude
            locations.ForEach(locA => {
                var coordA = new GeoCoordinate(locA.Location.Latitude, locA.Location.Longitude);
                // a nested locations.ForEach to look compare all the locations, second location declared as locB
                locations.ForEach(locB =>
                {
                    var coordB = new GeoCoordinate(locB.Location.Latitude, locB.Location.Longitude);
                    // utilize GeoCoordinate.GetDistanceTo so that I can find the distance between two points.
                    var dist = coordA.GetDistanceTo(coordB);
                    // Update the distance variable if the current iteration's distance is larger than the current distance stored.
                    if (dist > distance)
                    {
                        distance = dist;
                        tacoOne = locA;
                        tacoTwo = locB;
                    }
                });                      
            });
            // Write the results to the console.
            Console.WriteLine($"{tacoOne.Location.Latitude}, {tacoOne.Location.Longitude}, {tacoOne.Name}");
            Console.WriteLine($"{tacoTwo.Location.Latitude}, {tacoTwo.Location.Longitude}, {tacoTwo.Name}");
            Console.WriteLine($"Distance Between Locations: {distance}");
            Console.ReadKey();
        }
    }
}















            // Create a new corA Coordinate with your locA's lat and long

            // Now, do another loop on the locations with the scope of your first loop, so you can grab the "destination" location (perhaps: `locB`)

            // Create a new Coordinate with your locB's lat and long

            // Now, compare the two using `.GetDistanceTo()`, which returns a double
            // If the distance is greater than the currently saved distance, update the distance and the two `ITrackable` variables you set above

            // Once you've looped through everything, you've found the two Taco Bells farthest away from each other.

        //static readonly ILog logger = new TacoLogger();
            // TODO:  Find the two Taco Bells that are the furthest from one another.
            // HINT:  You'll need two nested forloops ---------------------------

            //logger.LogInfo("Log initialized");

            // use File.ReadAllLines(path) to grab all the lines from your csv file
            // Log and error if you get 0 lines and a warning if you get 1 line
            

            //logger.LogInfo($"Lines: {lines[0]}");

            // DON'T FORGET TO LOG YOUR STEPS

            // Now that your Parse method is completed, START BELOW ----------

            // TODO: Create two `ITrackable` variables with initial values of `null`. These will be used to store your two taco bells that are the farthest from each other.
            // Create a `double` variable to store the distance


            // Include the Geolocation toolbox, so you can compare locations: `using GeoCoordinatePortable;`

            //HINT NESTED LOOPS SECTION---------------------
            // Do a loop for your locations to grab each location as the origin (perhaps: `locA`)
