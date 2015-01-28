namespace TvSorter.Tests.Double
{
    using Configuration;

    public class ConfigurationDouble : AbstractConfigurationSupplied
    {
        public ConfigurationDouble(string destination, string release, bool checkForShowName = false)
        {
            Destination = destination;
            Release = release;
            CheckForShowName = checkForShowName;
        }
    }
}