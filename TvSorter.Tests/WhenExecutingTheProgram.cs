

namespace TvSorter.Tests
{
    using System;
    using Double;
    using FluentAssertions;
    using NUnit.Framework;
    using Output;

    [TestFixture]
    public class WhenExecutingTheProgram
    {
        [Test]
        public void GivenAMoveRequestNoFilesOnTheFileSystemAMessageShouldBePrinted()
        {
            var resolve = new ResolveDouble(new ConfigurationDouble(@"c:\destination", @"c:\release"));

            var programExecution = new ProgramExecution(resolve);

            programExecution.Execute();
            var output = resolve.For<IOutput>();

            output.Lines.Should().Be(@"Release directory doesn't exist c:\release");
        }

        [Test]
        public void GivenAShowInfoRequestNoFilesOnTheFileSystemAMessageShouldBePrinted()
        {
            var resolve = new ResolveDouble(new ConfigurationDouble(@"c:\destination", @"c:\release", true));

            var programExecution = new ProgramExecution(resolve);

            programExecution.Execute();
            var output = resolve.For<IOutput>();

            output.Lines.Should().Be(@"Release directory doesn't exist c:\release");
        }

        [Test]
        public void GivenAnInvalidConfigurationTheExecutionShouldBeHaltedWhenMovingARelease()
        {
            var resolve = new ResolveDouble(new ConfigurationDouble(@"", @""));
            
            var programExecution = new ProgramExecution(resolve);

            programExecution.Execute();

            var output = resolve.For<IOutput>();
            output.Lines.Trim().Should().EndWithEquivalent("{Extension}");
        }

        [Test]
        public void GivenAnInvalidConfigurationTheExecutionShouldBeHaltedWhenCheckingForShowInfo()
        {
            var resolve = new ResolveDouble(new ConfigurationDouble(@"", @"", true));

            var programExecution = new ProgramExecution(resolve);

            programExecution.Execute();

            var output = resolve.For<IOutput>();
            output.Lines.Trim().Should().EndWithEquivalent("{Extension}");
        }
    }
}