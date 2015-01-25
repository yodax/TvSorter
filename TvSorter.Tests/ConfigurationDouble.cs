namespace TvSorter.Tests
{
    using Configuration;

    public class ConfigurationDouble : SuppliedConfiguration
    {
        public ConfigurationDouble(string destination, string release, bool checkForShowName = false)
        {
            Destination = destination;
            Release = release;
            CheckForShowName = checkForShowName;
        }
    }
}