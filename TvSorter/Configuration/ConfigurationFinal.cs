namespace TvSorter.Configuration
{
    using System.IO.Abstractions;
    using Output;

    public class ConfigurationFinal : IConfiguration
    {
        private const string ConfigurationFileName = "tvsorter.ini";

        public ConfigurationFinal(SuppliedConfiguration suppliedConfiguration, IFileSystem fileSystem, IOutput output)
        {
            if (!string.IsNullOrEmpty(suppliedConfiguration.Destination))
            {
                Destination = suppliedConfiguration.Destination;
            }
            if (!string.IsNullOrEmpty(suppliedConfiguration.Release))
            {
                Release = suppliedConfiguration.Release;
            }

            CheckForShowName = suppliedConfiguration.CheckForShowName;

            if (string.IsNullOrEmpty(Destination) && fileSystem.File.Exists(ConfigurationFileName))
            {
                var textFile = fileSystem.File.ReadAllText(ConfigurationFileName);
                Destination = textFile.Split('=')[1];
            }

            if ((string.IsNullOrEmpty(Destination) || string.IsNullOrEmpty(Release)) &&
                !fileSystem.File.Exists(ConfigurationFileName))
            {
                output.AddLine(@" Line                                                              ");
                output.AddLine(@" Please add a configuration file called <TvSorter.ini> containing: ");
                output.AddLine(@"                                                                   ");
                output.AddLine(@" destination=<Path to destination>                                 ");
                output.AddLine(@"                                                                   ");
                output.AddLine(@" OR                                                                ");
                output.AddLine(@"                                                                   ");
                output.AddLine(@" Supply the following arguments (-r is mandatory):                 ");
                output.AddLine(@"                                                                   ");
                output.AddLine(@" -r OR --release <Path to release>                                 ");
                output.AddLine(@" -d OR --destination <Path to destination>                         ");
                output.AddLine(@"                                                                   ");
                output.AddLine(@" <Path to destination> can be formatted like:                      ");
                output.AddLine(@" c:\tv\{ShowName}\{SeasonEpisode}\{ReleaseName}.{Extension}        ");
            }
        }

        public string Destination { get; private set; }
        public string Release { get; private set; }
        public bool CheckForShowName { get; private set; }
    }
}