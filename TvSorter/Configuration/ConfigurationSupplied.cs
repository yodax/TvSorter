namespace TvSorter.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ConfigurationSupplied : SuppliedConfiguration
    {
        public ConfigurationSupplied(string[] arguments)
        {
            Destination = FindConfigurationInCommandLineArguments(new[] {"-d", "--destination"}, arguments);
            Release = FindConfigurationInCommandLineArguments(new[] {"-r", "--release"}, arguments);
            CheckForShowName = arguments.Contains("--showName");
        }

        private static string FindConfigurationInCommandLineArguments(IEnumerable<string> parameterName,
            string[] arguments)
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