namespace TvSorter.Tests
{
    public class ConfigurationDouble : SuppliedConfiguration
    {
        public ConfigurationDouble(string destination, string release)
        {
            Destination = destination;
            Release = release;
        }
    }
}