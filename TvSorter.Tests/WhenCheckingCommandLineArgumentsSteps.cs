namespace TvSorter.Tests
{
    using FluentAssertions;
    using TechTalk.SpecFlow;

    [Binding]
    public class WhenCheckingCommandLineArgumentsSteps
    {
        private ConfigurationFromCommandLineParameters configuration;

        [Given(@"the commandline parameters (.*)")]
        public void GivenTheCommandlineParameters(string commandLineParameters)
        {
            configuration = new ConfigurationFromCommandLineParameters(commandLineParameters.Split(' '));
        }

        [Then(@"the configuration setting destination is (.*)")]
        public void ThenTheConfigurationSettingDestinationIsDestination(string configurationValue)
        {
            configuration.Destination.Should().Be(configurationValue);
        }

        [Then(@"the configuration setting release is (.*)")]
        public void ThenTheConfigurationSettingReleaseIsRelease(string configurationValue)
        {
            configuration.Release.Should().Be(configurationValue);
        }
    }
}