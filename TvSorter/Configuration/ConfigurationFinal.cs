namespace TvSorter.Configuration
{
    using System;
    using System.IO.Abstractions;
    using Output;

    public class ConfigurationFinal : IConfiguration
    {
        private const string ConfigurationFileName = "tvsorter.ini";

        public ConfigurationFinal(AbstractConfigurationSupplied abstractConfigurationSupplied, IFileSystem fileSystem, IOutput output)
        {
            if (!string.IsNullOrEmpty(abstractConfigurationSupplied.Destination))
            {
                Destination = abstractConfigurationSupplied.Destination;
            }
            if (!string.IsNullOrEmpty(abstractConfigurationSupplied.Release))
            {
                Release = abstractConfigurationSupplied.Release;
            }

            CheckForShowName = abstractConfigurationSupplied.CheckForShowName;

            if (WeHaveNoSuppliedDestinationButAConfigFileExistsOnDisk(fileSystem))
            {
                var textFile = fileSystem.File.ReadAllText(ConfigurationFileName);
                var strings = textFile.Split('=');

                if (strings.Length == 2 && strings[0].Equals("destination", StringComparison.InvariantCultureIgnoreCase))
                    Destination = strings[1];
            }

            if (
                    WeAreCheckingForShowNameButWeDontHaveARelease()
                    ||
                    WeAreMovingAReleaseButDontHaveAReleaseOrADestination()
                )
            {
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
                output.AddLine(@" --showinfo <Path to destination>                                  ");
                output.AddLine(@"                                                                   ");
                output.AddLine(@" <Path to destination> can be formatted like:                      ");
                output.AddLine(@" c:\tv\{ShowName}\{SeasonEpisode}\{ReleaseName}.{Extension}        ");
            }
            else
            {
                IsValid = true;
            }
        }

        private bool WeHaveNoSuppliedDestinationButAConfigFileExistsOnDisk(IFileSystem fileSystem)
        {
            return string.IsNullOrEmpty(Destination) && fileSystem.File.Exists(ConfigurationFileName);
        }

        private bool WeAreMovingAReleaseButDontHaveAReleaseOrADestination()
        {
            return (!CheckForShowName && (string.IsNullOrEmpty(Release) || string.IsNullOrEmpty(Destination)));
        }

        private bool WeAreCheckingForShowNameButWeDontHaveARelease()
        {
            return (CheckForShowName && string.IsNullOrEmpty(Release));
        }

        public string Destination { get; private set; }
        public string Release { get; private set; }
        public bool CheckForShowName { get; private set; }
        public bool IsValid { get; private set; }
    }
}