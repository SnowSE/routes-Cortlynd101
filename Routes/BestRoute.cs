using System;
using System.Collections.Generic;

namespace Routes
{
    public class BestRoute
    {
        public List<string> bestRouteCitiesList { get; set; }
        public int bestDistance = 0;
        
        public BestRoute getBestRoute(RouteList routeList)
        {
            BestRoute bestPath = new BestRoute();
            bestPath.bestRouteCitiesList = new List<string>();
            List<Route> paths = routeList.routeList;
            string initialCity = paths[0].firstCity;
            bestPath.bestRouteCitiesList.Add(paths[0].firstCity);

            TraverseBestPath(bestPath, paths, initialCity);
            return bestPath;
        }

        private void TraverseBestPath(BestRoute bestPath, List<Route> paths, string initialCity)
        {
            for (int i = 0; i < paths.Count; i++)
            {
                int initialCityPosition = (bestPath.bestRouteCitiesList.Count) - 1;
                initialCity = bestPath.bestRouteCitiesList[initialCityPosition];
                FindNextBestRoute(bestPath, paths, initialCity);
            }
        }

        private void FindNextBestRoute(BestRoute bestPath, List<Route> paths, string initialCity)
        {
            int listIndex = 0;
            int smallestRouteDistance = 9999999;
            int smallestRouteIndex = 0;

            foreach (Route path in paths)
            {
                if (path.firstCity == initialCity)
                {
                    if (path.distance < smallestRouteDistance)
                    {
                        smallestRouteDistance = path.distance;
                        smallestRouteIndex = listIndex;
                    }
                }
                listIndex++;
            }

            AddCityToList(bestPath, paths, smallestRouteDistance, smallestRouteIndex);
        }
        private void AddCityToList(BestRoute bestPath, List<Route> paths, int smallestRouteDistance, int smallestRouteIndex)
        {
            if (CheckIfCityInList(paths[smallestRouteIndex].secondCity, bestPath.bestRouteCitiesList) == false)
            {
                bestPath.bestDistance += smallestRouteDistance;
                bestPath.bestRouteCitiesList.Add(paths[smallestRouteIndex].secondCity);
                paths.Remove(paths[smallestRouteIndex]);
            }
        }
        public bool CheckIfCityInList(string cityToCheck, List<string> listToCheck)
        {
            bool cityIsInList = false;
            foreach(string city in listToCheck)
            {
                if(cityToCheck == city)
                {
                    cityIsInList = true;
                }
            }
            return cityIsInList;
        }
    }
}
