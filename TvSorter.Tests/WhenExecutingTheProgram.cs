using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvSorter.Tests
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    class WhenExecutingTheProgram
    {
        [TestMethod]
        public void WithoutArgumentsItShouldExitNormally()
        {
            Action program = () => Program.Main(new string[0]);

            program.ShouldNotThrow<Exception>();
        }
    }
}
