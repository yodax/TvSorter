namespace TvSorter.Tests
{
    using System.IO.Abstractions;
    using System.IO.Abstractions.TestingHelpers;
    using Autofac;

    public class ResolveDouble : IResolve
    {
        private readonly ILifetimeScope scope;

        public ResolveDouble(SuppliedConfiguration configurationDouble)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MockFileSystem>().As<IFileSystem>().InstancePerLifetimeScope();
            builder.RegisterInstance(new OutputDouble()).As<IOutput>();
            builder.RegisterInstance(configurationDouble).As<SuppliedConfiguration>();
            builder.RegisterType<FinalConfiguration>().As<IConfiguration>().InstancePerLifetimeScope();
            builder.RegisterType<MoveRelease>().As<IMoveRelease>().InstancePerLifetimeScope();
            builder.RegisterType<ShowNameFinder>().As<IShowNameFinder>().InstancePerLifetimeScope();
            builder.RegisterType<MoveReleaseOutput>();
            builder.RegisterType<ExtractShowInfoFromRelease>();

            scope = builder.Build().BeginLifetimeScope();
        }

        public T For<T>()
        {
            return scope.Resolve<T>();
        }
    }
}