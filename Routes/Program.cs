using System;

namespace Routes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RouteList routeList = new RouteList();
            routeList = routeList.createRouteList(routeList, @"C:\Users\Cortl\Source\Repos\routes-Cortlynd101\Routes\TestInput.txt");

            //RouteList inputeRouteList = new RouteList();
            //inputeRouteList = inputeRouteList.createRouteList(inputeRouteList, @"C:\Users\Cortl\Source\Repos\routes-Cortlynd101\Routes\Input.txt");
        } //This break point makes it easy to see what is in routeList.
    }
}