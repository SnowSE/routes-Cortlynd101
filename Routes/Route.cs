using System;

namespace Routes
{
    public class Route
    {
        public string firstCity { get; set; }
        public string secondCity { get; set; }
        public int distance { get; set; }
        
        public Route()
        {
            distance = 0;
        }
        public Route createRoute(string line)
        {
            Route routeCreated = new Route();
            string[] lineSplitArray = splitLine(line);
            routeCreated = routeCreated.setCities(routeCreated, lineSplitArray);
            routeCreated = routeCreated.setDistance(routeCreated, lineSplitArray);
            return routeCreated;
        }

        private Route setDistance(Route routeCreated, string[] lineSplitArray)
        {
            routeCreated.distance = Int32.Parse(lineSplitArray[2]);
            return routeCreated;
        }

        private Route setCities(Route routeCreated, string[] lineSplitArray)
        {
            routeCreated.firstCity = lineSplitArray[0];
            routeCreated.secondCity = lineSplitArray[1];
            return routeCreated;
        }

        private string[] splitLine(string line)
        {
            string[] splitLineArray = line.Split(' ');
            splitLineArray = getRidOfToAndEquals(splitLineArray);
            return splitLineArray;
        }

        private string[] getRidOfToAndEquals(string[] splitLineArray)
        {
            string[] correctedSplitLineArray = new string[3]; //We do this to get rid of the "to" and "="
            for (int i = 0; i < 3; i++)
            {
                correctedSplitLineArray[i] = splitLineArray[i*2].Trim();
            }
            return correctedSplitLineArray;
        }
    }
}
