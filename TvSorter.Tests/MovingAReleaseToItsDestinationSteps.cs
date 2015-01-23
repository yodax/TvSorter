namespace TvSorter.Tests
{
    using System.IO.Abstractions;
    using System.Linq;
    using FluentAssertions;
    using TechTalk.SpecFlow;

    [Binding]
    public class MovingAReleaseToItsDestinationSteps
    {
        private ResolveDouble resolve;

        [Given(@"a tv destination of (.*)")]
        public void GivenATvDestinationOf(string destination)
        {
            resolve = new ResolveDouble(new ConfigurationDouble(destination, ""));
        }

        [Given(@"a release in (.*)")]
        public void GivenAReleaseInIn(string releaseDirectory)
        {
            ScenarioContext.Current.Add("releaseDirectory", releaseDirectory);
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

            moveRelease.From(ScenarioContext.Current["releaseDirectory"].ToString());
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
        public void ThenTheOutputShouldBe(Table table)
        {
            var output = resolve.For<IOutput>();

            table.Rows.Select(r => r["Line"]).ShouldAllBeEquivalentTo(output.Lines);
        }
    }
}