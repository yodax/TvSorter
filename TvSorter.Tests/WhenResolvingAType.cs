namespace TvSorter.Tests
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class WhenResolvingAType
    {
        private IResolve resolve;

        [TestInitialize]
        public void Setup()
        {
            resolve = new ResolveDouble(new ConfigurationDouble(""));
        }

        [TestMethod]
        public void ConfigurationShouldBeResolveable()
        {
            resolve.For<IConfiguration>().Should().BeAssignableTo<IConfiguration>();
        }
    }
}