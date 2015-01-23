namespace TvSorter.Tests
{
    using System.IO.Abstractions;
    using System.IO.Abstractions.TestingHelpers;
    using Autofac;

    public class ResolveDouble : IResolve
    {
        private readonly ILifetimeScope scope;

        public ResolveDouble(ConfigurationDouble configurationDouble)
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterType<MockFileSystem>().As<IFileSystem>().InstancePerLifetimeScope();
            builder.RegisterInstance(configurationDouble).As<IConfiguration>();
            builder.RegisterType<MoveRelease>().As<IMoveRelease>().InstancePerLifetimeScope();
            builder.RegisterInstance(new OutputDouble()).As<IOutput>();
            
            scope = builder.Build().BeginLifetimeScope();
        }
        public T For<T>()
        {
            return scope.Resolve<T>();
        }
    }
}