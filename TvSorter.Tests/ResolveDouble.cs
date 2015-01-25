﻿namespace TvSorter.Tests
{
    using System.IO.Abstractions;
    using System.IO.Abstractions.TestingHelpers;
    using Autofac;
    using Configuration;
    using Output;

    public class ResolveDouble : IResolve
    {
        private readonly ILifetimeScope scope;

        public ResolveDouble(SuppliedConfiguration configurationDouble)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MockFileSystem>().As<IFileSystem>().InstancePerLifetimeScope();
            builder.RegisterInstance(configurationDouble).As<SuppliedConfiguration>();
            builder.RegisterType<ConfigurationFinal>().As<IConfiguration>().InstancePerLifetimeScope();
            builder.RegisterInstance(new OutputDouble()).As<IOutput>();
            builder.RegisterType<MoveRelease>();
            builder.RegisterType<ShowNameFinder>();
            builder.RegisterType<MoveReleaseOutput>();
            builder.RegisterType<ReleaseInformationOnFileSystem>();

            scope = builder.Build().BeginLifetimeScope();
        }

        public T For<T>()
        {
            return scope.Resolve<T>();
        }
    }
}