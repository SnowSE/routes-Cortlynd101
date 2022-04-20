using System;
using System.Collections.Generic;

namespace Routes
{
    public class RouteList
    {
        public List<Route> routeList { get; set; }
        public RouteList()
        {
            routeList = new List<Route>();
        }
        public RouteList createRouteList(RouteList routeList, string filePath)
        {
            string line;
            System.IO.StreamReader fileReadAgain = new System.IO.StreamReader(filePath);
            Route newRoute = new Route();

            while ((line = fileReadAgain.ReadLine()) != null)
            {
                newRoute = newRoute.createRoute(line);
                routeList.routeList.Add(newRoute);
            }
            return routeList;
        }
    }
}
