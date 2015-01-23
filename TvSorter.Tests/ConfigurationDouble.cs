namespace TvSorter.Tests
{
    public class ConfigurationDouble : IConfiguration
    {
        private readonly string destination;

        public ConfigurationDouble(string destination)
        {
            this.destination = destination;
        }

        public string Destination
        {
            get { return destination; }
        }
    }
}