namespace TvSorter.Tests
{
    using System;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Output;

    [TestClass]
    public class WhenExecutingTheProgram
    {
        [TestMethod]
        public void GivenAMoveRequestNoFilesOnTheFileSystemAMessageShouldBePrinted()
        {
            var resolve = new ResolveDouble(new ConfigurationDouble(@"c:\destination", @"c:\release"));

            var programExecution = new ProgramExecution(resolve);

            programExecution.Execute();
            var output = resolve.For<IOutput>();

            output.Lines.Should().Be(@"Release directory doesn't exist c:\release");
        }

        [TestMethod]
        public void GivenAShowInfoRequestNoFilesOnTheFileSystemAMessageShouldBePrinted()
        {
            var resolve = new ResolveDouble(new ConfigurationDouble(@"c:\destination", @"c:\release", true));

            var programExecution = new ProgramExecution(resolve);

            programExecution.Execute();
            var output = resolve.For<IOutput>();

            output.Lines.Should().Be(@"Release directory doesn't exist c:\release");
        }
    }
}