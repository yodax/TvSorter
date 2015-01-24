namespace TvSorter.Tests
{
    using System.Collections.Generic;
    using System.IO.Abstractions;
    using FluentAssertions;
    using TechTalk.SpecFlow;

    [Binding]
    public class WhenCheckingCommandLineArgumentsSteps
    {
        private ResolveDouble resolve;

        [Given(@"the commandline parameters (.*)")]
        public void GivenTheCommandlineParameters(string commandLineParameters)
        {
            resolve = new ResolveDouble(new ConfigurationFromCommandLineParameters(commandLineParameters.Split(' ')));
        }

        [Then(@"the configuration setting destination is (.*)")]
        public void ThenTheConfigurationSettingDestinationIsDestination(string configurationValue)
        {
            resolve.For<IConfiguration>().Destination.Should().Be(configurationValue);
        }

        [Then(@"the configuration setting release is (.*)")]
        public void ThenTheConfigurationSettingReleaseIsRelease(string configurationValue)
        {
            resolve.For<IConfiguration>().Release.Should().Be(configurationValue);
        }

        [Given(@"no configuration file is present")]
        public void GivenNoConfigurationFileIsPresent()
        {
            resolve.For<IConfiguration>();
        }

        [Given(@"No command line parameters")]
        public void GivenNoCommandLineParameters()
        {
            resolve = new ResolveDouble(new ConfigurationFromCommandLineParameters(new string[0]));
        }

        [Then(@"the output should be a statment defining the usage of the program")]
        public void ThenTheOutputShouldBeAStatmentDefiningTheUsageOfTheProgram()
        {
            var output = resolve.For<IOutput>();

            var expectedOutput = new List<string>
            {
                @" Line                                                              ",
                @" Please add a configuration file called <TvSorter.ini> containing: ",
                @"                                                                   ",
                @" destination=<Path to destination>                                 ",
                @"                                                                   ",
                @" OR                                                                ",
                @"                                                                   ",
                @" Supply the following arguments (-r is mandatory):                 ",
                @"                                                                   ",
                @" -r OR --release <Path to release>                                 ",
                @" -d OR --destination <Path to destination>                         ",
                @"                                                                   ",
                @" <Path to destination> can be formatted like:                      ",
                @" c:\tv\{ShowName}\{SeasonEpisode}\{ReleaseName}.{Extension}        "
            };

            output.Lines.ShouldBeEquivalentTo(expectedOutput);
        }

        [Given(@"the configuration file")]
        public void GivenTheConfigurationFile(string multilineText)
        {
            var fileSystem = resolve.For<IFileSystem>();

            var text = fileSystem.File.CreateText("tvsorter.ini");
            text.Write(multilineText);
            text.Close();
        }
    }
}