namespace TvSorter
{
    using System;
    using System.Collections.Generic;

    public class ConfigurationFromCommandLineParameters : IConfiguration
    {
        private readonly string destination;
        private readonly string release;

        public ConfigurationFromCommandLineParameters(string[] arguments)
        {
            destination = FindConfigurationInCommandLineArguments(new[] {"-d", "--destination"}, arguments);
            release = FindConfigurationInCommandLineArguments(new[] {"-r", "--release"}, arguments);
        }

        public string Destination
        {
            get { return destination; }
        }

        public string Release
        {
            get { return release; }
        }

        private string FindConfigurationInCommandLineArguments(IEnumerable<string> parameterName, string[] arguments)
        {
            foreach (var parameter in parameterName)
            {
                var check = Array.IndexOf(arguments, parameter);
                if (check >= 0)
                {
                    return arguments[check + 1].Replace("\"", "");
                }
            }
            return string.Empty;
        }
    }
}