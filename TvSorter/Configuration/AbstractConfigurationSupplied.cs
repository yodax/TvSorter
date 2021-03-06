namespace TvSorter.Configuration
{
    public abstract class AbstractConfigurationSupplied : IConfiguration
    {
        public string Destination { get; protected set; }
        public string Release { get; protected set; }
        public bool CheckForShowName { get; protected set; }
        public bool IsValid { get; protected set; }
    }
}