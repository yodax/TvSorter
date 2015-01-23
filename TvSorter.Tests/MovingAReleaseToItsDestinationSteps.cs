namespace TvSorter.Tests
{
    using System.Collections;
    using System.IO.Abstractions;
    using System.IO.Abstractions.TestingHelpers;
    using System.Linq;
    using Autofac;
    using FluentAssertions;
    using TechTalk.SpecFlow;

    [Binding]
    public class MovingAReleaseToItsDestinationSteps
    {
        private ILifetimeScope lifetimeScope;

        [Given(@"a tv destination of (.*)")]
        public void GivenATvDestinationOf(string destination)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MockFileSystem>().As<IFileSystem>().InstancePerLifetimeScope();
            builder.RegisterInstance(new ConfigurationDouble(destination)).As<IConfiguration>();
            builder.RegisterType<MoveRelease>().As<IMoveRelease>().InstancePerLifetimeScope();
            builder.RegisterInstance(new OutputDouble()).As<IOutput>();
            var container = builder.Build();
            lifetimeScope = container.BeginLifetimeScope();
        }

        [Given(@"a release in (.*)")]
        public void GivenAReleaseInIn(string releaseDirectory)
        {
            ScenarioContext.Current.Add("releaseDirectory", releaseDirectory);
        }

        [Given(@"a directory structure")]
        public void GivenADirectoryStructure(Table table)
        {
            var fileSystem = lifetimeScope.Resolve<IFileSystem>();
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
            var moveRelease = lifetimeScope.Resolve<IMoveRelease>();

            moveRelease.From(ScenarioContext.Current["releaseDirectory"].ToString());
        }

        [Then(@"the directory structure should contain")]
        public void ThenTheDirectoryStructureShouldContain(Table table)
        {
            var fileSystem = lifetimeScope.Resolve<IFileSystem>();

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
            var fileSystem = lifetimeScope.Resolve<IFileSystem>();

            fileSystem.Directory.GetFiles(directory).Should().BeEmpty();
            fileSystem.Directory.GetDirectories(directory).Should().BeEmpty();
        }

        [Then(@"the output should be")]
        public void ThenTheOutputShouldBe(Table table)
        {
            var output = lifetimeScope.Resolve<IOutput>();

            table.Rows.Select(r => r["Line"]).ShouldAllBeEquivalentTo(output.Lines);
        }

    }
}