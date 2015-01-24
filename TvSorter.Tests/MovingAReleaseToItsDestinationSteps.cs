namespace TvSorter.Tests
{
    using System;
    using System.IO;
    using System.IO.Abstractions;
    using System.Linq;
    using FluentAssertions;
    using TechTalk.SpecFlow;

    [Binding]
    public class MovingAReleaseToItsDestinationSteps
    {
        private ResolveDouble resolve;

        private static string ReleaseDirectory
        {
            get { return ScenarioContext.Current["releaseDirectory"].ToString(); }
        }

        [Given(@"a tv destination of (.*)")]
        public void GivenATvDestinationOf(string destination)
        {
            resolve =
                new ResolveDouble(new ConfigurationDouble(destination,
                    ReleaseDirectory));
        }

        [Given(@"a release in (.*)")]
        public void GivenAReleaseInIn(string releaseDirectoryFromSpecFlow)
        {
            ScenarioContext.Current.Add("releaseDirectory", releaseDirectoryFromSpecFlow);
        }

        [Given(@"a directory structure")]
        public void GivenADirectoryStructure(Table table)
        {
            var fileSystem = resolve.For<IFileSystem>();
            foreach (var tableRow in table.Rows)
            {
                if (tableRow["Type"].Equals("Directory"))
                {
                    fileSystem.Directory.CreateDirectory(tableRow["Item"]);
                }
                if (tableRow["Type"].Equals("File"))
                {
                    fileSystem.File.CreateText(tableRow["Item"]).Close();
                }
            }
        }

        [When(@"we request a move")]
        public void WhenWeRequestAMove()
        {
            var moveRelease = resolve.For<IMoveRelease>();

            moveRelease.From(ReleaseDirectory);
        }

        [Then(@"the directory structure should contain")]
        public void ThenTheDirectoryStructureShouldContain(Table table)
        {
            var fileSystem = resolve.For<IFileSystem>();

            foreach (var tableRow in table.Rows)
            {
                if ((tableRow.ContainsKey("Type") && tableRow["Type"].Equals("File")) || (!tableRow.ContainsKey("Type")))
                    fileSystem.File.Exists(tableRow["Item"]).Should().BeTrue();
                if (tableRow.ContainsKey("Type") && tableRow["Type"].Equals("Directory"))
                    fileSystem.Directory.Exists(tableRow["Item"]).Should().BeTrue();
            }
        }

        [Then(@"the directory (.*) should be empty")]
        public void ThenTheDirectoryCIncomingShouldBeEmpty(string directory)
        {
            var fileSystem = resolve.For<IFileSystem>();

            fileSystem.Directory.GetFiles(directory).Should().BeEmpty();
            fileSystem.Directory.GetDirectories(directory).Should().BeEmpty();
        }

        [Then(@"the output should be")]
        public void ThenTheOutputShouldBe(string multiLineText)
        {
            var output = resolve.For<IOutput>();

            output.Lines.Replace(Environment.NewLine, "").Replace("\n", "").Should().BeEquivalentTo(multiLineText.Replace(Environment.NewLine, "").Replace("\n", ""));
        }

        [Given(@"a file with extenstion (.*)")]
        public void GivenAFileWithExtenstion(string extension)
        {
            CreateAnEmptyFile("Show.S01E01.HDTV-NOGROUP." + extension);

            // We need at least one media file present for this to work
            var nonMediaExtensions = new[] {"nfo", "srt", "sub", "idx"};
            if (nonMediaExtensions.Any(ext => ext.Equals(extension)))
                CreateAnEmptyFile("Show.S01E01.HDTV-NOGROUP." + "mkv");
        }

        private void CreateAnEmptyFile(string fileName)
        {
            var fileSystem = resolve.For<IFileSystem>();

            fileSystem.File.Create(CombineFileNameWithReleaseDirectory(fileName))
                .Close();
        }

        private string CombineFileNameWithReleaseDirectory(string fileName)
        {
            return Path.Combine(ReleaseDirectory, fileName);
        }

        [Given(@"a file with a non allowed extension (.*)")]
        public void GivenAFileWithANonAllowedExtensionRar(string extension)
        {
            CreateAnEmptyFile("fileName." + extension);
        }

        [Then(@"the directory structure should not contain a file with (.*)")]
        public void ThenTheDirectoryStructureShouldNotContainAFileWithRar(string extension)
        {
            resolve.For<IFileSystem>()
                .File.Exists(@"c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP." + extension)
                .Should()
                .BeFalse();
        }

        [Then(@"the directory structure should contain a file (.*)")]
        public void ThenTheDirectoryStructureShouldContainAFileMkv(string extension)
        {
            resolve.For<IFileSystem>()
                .File.Exists(@"c:\tv\Show\S01E01\Show.S01E01.HDTV-NOGROUP." + extension)
                .Should()
                .BeTrue();
        }

        [Then(@"the release should not have been removed")]
        public void ThenTheReleaseShouldNotHaveBeenRemoved()
        {
            resolve.For<IFileSystem>()
                .Directory.Exists(ReleaseDirectory)
                .Should()
                .BeTrue();
        }

        [Given(@"the files in the release directory")]
        public void GivenTheFilesInTheReleaseDirectory(Table table)
        {
            var fileSystem = resolve.For<IFileSystem>();
            foreach (var tableRow in table.Rows)
            {
                if (tableRow.ContainsKey("Type") && tableRow["Type"].Equals("Directory"))
                {
                    fileSystem.Directory.CreateDirectory(
                        Path.Combine(ReleaseDirectory, tableRow["Item"]));
                }
                else
                {
                    fileSystem.File.CreateText(
                        Path.Combine(ReleaseDirectory, tableRow["Item"]))
                        .Close();
                }
            }
        }

        [Given(@"an info file in the release directory")]
        public void GivenAnInfoFileInTheReleaseDirectory(string multilineText)
        {
            var textWriter =
                resolve.For<IFileSystem>()
                    .File.CreateText(Path.Combine(ReleaseDirectory, "info.nfo"));

            textWriter.Write(multilineText);
            textWriter.Close();
        }

        [Then(@"the output should not contain (.*)")]
        public void ThenTheOutputShouldNotContainNFOFile(string stringToSearchFor)
        {
            var output = resolve.For<IOutput>();

            output.Lines.Should().NotContainEquivalentOf(stringToSearchFor);
        }

    }
}