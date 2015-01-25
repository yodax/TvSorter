namespace TvSorter.Tests
{
    using System;
    using System.Collections.Generic;
    using System.IO.Abstractions;
    using Configuration;
    using FluentAssertions;
    using Output;
    using TechTalk.SpecFlow;

    [Binding]
    public class WhenCheckingCommandLineArgumentsSteps
    {
        private IResolve resolve;

        [Given(@"the commandline parameters (.*)")]
        public void GivenTheCommandlineParameters(string commandLineParameters)
        {
            resolve = new ResolveDouble(new ConfigurationSupplied(commandLineParameters.Split(' ')));
        }

        [Then(@"the configuration setting destination is (.*)")]
        public void ThenTheConfigurationSettingDestinationIsDestination(string configurationValue)
        {
            if (!string.IsNullOrEmpty(configurationValue))
                resolve.For<IConfiguration>().Destination.Should().Be(configurationValue);
        }

        [Then(@"the configuration setting release is (.*)")]
        public void ThenTheConfigurationSettingReleaseIsRelease(string configurationValue)
        {
            var release = resolve.For<IConfiguration>().Release ?? "";
            release.Should().Be(configurationValue);
        }

        [Given(@"no configuration file is present")]
        public void GivenNoConfigurationFileIsPresent()
        {
            resolve.For<IConfiguration>();
        }

        [Given(@"No command line parameters")]
        public void GivenNoCommandLineParameters()
        {
            resolve = new ResolveDouble(new ConfigurationSupplied(new string[0]));
        }

        [Then(@"the configuration should be marked as (.*)")]
        public void ThenTheConfigurationShouldBeMarkedAs(string valid)
        {
            resolve.For<IConfiguration>().IsValid.Should().Be(valid.Equals("valid", StringComparison.InvariantCultureIgnoreCase));
        }

        [Then(@"the output should be a statment defining the usage of the program")]
        public void ThenTheOutputShouldBeAStatmentDefiningTheUsageOfTheProgram()
        {
            if (resolve == null)
                resolve = (IResolve) ScenarioContext.Current["resolve"];

            var output = resolve.For<IOutput>();

            var expectedOutput = new List<string>
            {
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
                @" --showinfo <Path to destination>                                  ",
                @"                                                                   ",
                @" <Path to destination> can be formatted like:                      ",
                @" c:\tv\{ShowName}\{SeasonEpisode}\{ReleaseName}.{Extension}        "
            };

            output.Lines.ShouldBeEquivalentTo(string.Join(Environment.NewLine, expectedOutput));
        }

        [Given(@"the configuration file")]
        public void GivenTheConfigurationFile(string multilineText)
        {
            var fileSystem = resolve.For<IFileSystem>();

            var text = fileSystem.File.CreateText("tvsorter.ini");
            text.Write(multilineText);
            text.Close();
        }

        [Then(@"the configuration setting to check for a show name is (.*)")]
        public void ThenTheConfigurationSettingToCheckForAShowNameIsNotSet(string set)
        {
            resolve.For<IConfiguration>()
                .CheckForShowName.Should().Be(set.Equals("set", StringComparison.InvariantCultureIgnoreCase));
        }

    }
}