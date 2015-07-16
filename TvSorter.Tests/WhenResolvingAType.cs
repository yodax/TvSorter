namespace TvSorter.Tests
{
    using System.IO.Abstractions;
    using Configuration;
    using Double;
    using FluentAssertions;
    using NUnit.Framework;
    using Output;

    [TestFixture]
    public class WhenResolvingAType
    {
        private IResolve resolveDouble;
        private IResolve actualResolve;

        [SetUp]
        public void Setup()
        {
            resolveDouble = new ResolveDouble(new ConfigurationDouble("", ""));
            actualResolve = new Resolve(new ConfigurationDouble("", ""));
        }

        [Test]
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