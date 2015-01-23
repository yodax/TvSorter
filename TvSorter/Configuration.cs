namespace TvSorter
{
    public class Configuration : IConfiguration
    {
        private readonly string destination;

        public Configuration()
        {
            destination = string.Empty;
        }

        public string Destination
        {
            get { return destination; }
        }
    }
}