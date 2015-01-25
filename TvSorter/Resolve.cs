namespace TvSorter
{
    using System.IO.Abstractions;
    using Autofac;
    using Configuration;
    using Output;

    public class Resolve : IResolve
    {
        private readonly ILifetimeScope scope;

        public Resolve(SuppliedConfiguration configurationFromCommandLine)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<FileSystem>().As<IFileSystem>().InstancePerLifetimeScope();
            builder.RegisterInstance(configurationFromCommandLine).As<SuppliedConfiguration>();
            builder.RegisterType<ConfigurationFinal>().As<IConfiguration>().InstancePerLifetimeScope();
            builder.RegisterInstance(new OutputConsolse()).As<IOutput>();
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