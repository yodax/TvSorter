namespace TvSorter.Tests
{
    using System.IO.Abstractions;
    using Configuration;
    using Double;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Output;

    [TestClass]
    public class WhenResolvingAType
    {
        private IResolve resolveDouble;
        private IResolve actualResolve;

        [TestInitialize]
        public void Setup()
        {
            resolveDouble = new ResolveDouble(new ConfigurationDouble("", ""));
            actualResolve = new Resolve(new ConfigurationDouble("", ""));
        }

        [TestMethod]
        public void AllTypesShouldBeAssignable()
        {
            CheckForResolve<IFileSystem>();
            CheckForResolve<IConfiguration>();
            CheckForResolve<IOutput>();
            CheckForResolve<MoveRelease>();
            CheckForResolve<ShowNameFinder>();
            CheckForResolve<MoveReleaseOutput>();
            CheckForResolve<ReleaseInformationOnFileSystem>();
        }

        private void CheckForResolve<T>()
        {
            resolveDouble.For<T>().Should().BeAssignableTo<T>();
            actualResolve.For<T>().Should().BeAssignableTo<T>();
        }
    }
}