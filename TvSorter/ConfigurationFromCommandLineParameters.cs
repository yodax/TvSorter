namespace TvSorter
{
    using System;
    using System.Collections.Generic;

    public class ConfigurationFromCommandLineParameters : SuppliedConfiguration
    {
        public ConfigurationFromCommandLineParameters(string[] arguments)
        {
            Destination = FindConfigurationInCommandLineArguments(new[] {"-d", "--destination"}, arguments);
            Release = FindConfigurationInCommandLineArguments(new[] {"-r", "--release"}, arguments);
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