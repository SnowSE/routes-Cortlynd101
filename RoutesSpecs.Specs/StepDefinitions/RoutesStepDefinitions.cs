using Routes;

namespace RoutesSpecs.Specs.StepDefinitions
{
    [Binding]
    public sealed class RoutesStepDefinitions
    {
        private readonly ScenarioContext context;
        public RoutesStepDefinitions(ScenarioContext context)
        {
            this.context = context;
        }
        [Given(@"the text file (.*)")]
        public void GivenTheTextFile(string file)
        {
            context.Add("file", file);
        }

        [When(@"creating possible routes")]
        public void WhenCreatingPossibleRoutes()
        {
            RouteList routeList = new RouteList();
            routeList = routeList.createRouteList(routeList, context.Get<string>("file"));
            context.Add("routeList", routeList);
        }

        [When(@"looking at a certain route number (.*)")]
        public void WhenLookingAtACertainRoute(int index)
        {
            Route route = context.Get<RouteList>("routeList").routeList[index];
            context.Add("route", route);
        }

        [Then(@"the first city should be (.*)")]
        public void ThenTheFirstCityShouldBe(string shouldBeFirstCity)
        {
            context.Get<Route>("route").firstCity.Should().Be(shouldBeFirstCity);
        }

        [Then(@"the second city should be (.*)")]
        public void ThenTheSecondCityShouldBe(string shouldBeSecondCity)
        {
            context.Get<Route>("route").secondCity.Should().Be(shouldBeSecondCity);
        }

        [Then(@"the distance should be (.*)")]
        public void ThenTheDistanceShouldBe(int shouldBeDistance)
        {
            context.Get<Route>("route").distance.Should().Be(shouldBeDistance);
        }

        [When(@"finding the best route")]
        public void WhenFindingTheBestRoute()
        {
            BestRoute bestRoute = new BestRoute();
            bestRoute = bestRoute.getBestRoute(context.Get<RouteList>("routeList"));
            context.Add("bestRoute", bestRoute);
        }

        [Then(@"the best first city should be (.*)")]
        public void ThenTheBestFirstCityShouldBe(string shouldBeBestFirstCity)
        {
            context.Get<BestRoute>("bestRoute").bestRouteCitiesList[0].Should().Be(shouldBeBestFirstCity);
        }

        [Then(@"the best second city should be (.*)")]
        public void ThenTheBestSecondCityShouldBe(string shouldBeBestSecondCity)
        {
            context.Get<BestRoute>("bestRoute").bestRouteCitiesList[1].Should().Be(shouldBeBestSecondCity);
        }

        [Then(@"the best third city should be (.*)")]
        public void ThenTheBestThirdCityShouldBe(string shouldBeBestThirdCity)
        {
            context.Get<BestRoute>("bestRoute").bestRouteCitiesList[2].Should().Be(shouldBeBestThirdCity);
        }

        [Then(@"the best distance should be (.*)")]
        public void ThenTheBestDistanceShouldBe(int shouldBeBestDistance)
        {
            context.Get<BestRoute>("bestRoute").bestDistance.Should().Be(shouldBeBestDistance);
        }
    }
}