namespace TvSorter.Tests
{
    public class ConfigurationDouble : IConfiguration
    {
        private readonly string destination;
        private readonly string release;

        public ConfigurationDouble(string destination, string release)
        {
            this.destination = destination;
            this.release = release;
        }

        public string Destination
        {
            get { return destination; }
        }

        public string Release
        {
            get { return release; }
        }
    }
}