namespace TvSorter.Tests
{
    using FluentAssertions;
    using Output;
    using TechTalk.SpecFlow;

    [Binding]
    public class WhenRequestingAShowNameSteps
    {
        private IResolve resolve;

        [When(@"we request a show name from the release directory")]
        public void WhenWeRequestAShowNameFromTheReleaseDirectory()
        {
            resolve = (IResolve)ScenarioContext.Current["resolve"];
            resolve.For<ShowNameFinder>().Find(ScenarioContext.Current["releaseDirectory"].ToString());
        }

        [Then(@"the requested show name should be (.*)")]
        public void ThenTheRequestedShowNameShouldBe(string expectedShowName)
        {
            var output = resolve.For<IOutput>();
            output.Lines.Should().Be(expectedShowName);
        }

    }
}