namespace TvSorter.Tests
{
    using System.IO.Abstractions;
    using System.IO.Abstractions.TestingHelpers;
    using Autofac;
    using FluentAssertions;
    using TechTalk.SpecFlow;

    [Binding]
    public class MovingAReleaseToItsDestinationSteps
    {
        private readonly ILifetimeScope lifetimeScope;

        public MovingAReleaseToItsDestinationSteps()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MockFileSystem>().As<IFileSystem>().InstancePerLifetimeScope();
            builder.RegisterType<Configuration>().InstancePerLifetimeScope();
            builder.RegisterType<MoveRelease>().As<IMoveRelease>().InstancePerLifetimeScope();
            var container = builder.Build();
            lifetimeScope = container.BeginLifetimeScope();

        }
        [Given(@"a tv destination of (.*)")]
        public void GivenATvDestinationOf(string destination)
        {
            var configuration = lifetimeScope.Resolve<Configuration>();
            configuration.Destination = destination;
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
                fileSystem.File.Exists(tableRow["Item"]).Should().BeTrue();
            }
        }

        [Then(@"the directory (.*) should be empty")]
        public void ThenTheDirectoryCIncomingShouldBeEmpty(string directory)
        {
            var fileSystem = lifetimeScope.Resolve<IFileSystem>();

            fileSystem.Directory.GetFiles(directory).Should().BeEmpty();
            fileSystem.Directory.GetDirectories(directory).Should().BeEmpty();
        }
    }
}