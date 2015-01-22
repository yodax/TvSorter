namespace TvSorter.Tests
{
    using System;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class WhenExecutingTheProgram
    {
        [TestMethod]
        public void WithoutArgumentsItShouldExitNormally()
        {
            Action program = () => Program.Main(new string[0]);

            program.ShouldNotThrow<Exception>();
        }
    }
}