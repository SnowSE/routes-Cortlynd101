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
            throw new PendingStepException();
        }

        [When(@"looking at a certain route number (.*)")]
        public void WhenLookingAtACertainRoute(int p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the first city should be (.*)")]
        public void ThenTheFirstCityShouldBe(string firstCity)
        {
            throw new PendingStepException();
        }

        [Then(@"the second city should be (.*)")]
        public void ThenTheSecondCityShouldBe(string secondCity)
        {
            throw new PendingStepException();
        }

        [Then(@"the distance should be (.*)")]
        public void ThenTheDistanceShouldBe(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"finding the best routes")]
        public void WhenFindingTheBestRoutes()
        {
            throw new PendingStepException();
        }

        [Then(@"the third city should be (.*)")]
        public void ThenTheThirdCityShouldBe(string thirdCity)
        {
            throw new PendingStepException();
        }
    }
}