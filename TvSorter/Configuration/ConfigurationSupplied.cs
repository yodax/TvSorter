namespace TvSorter.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ConfigurationSupplied : AbstractConfigurationSupplied
    {
        public ConfigurationSupplied(string arguments)
        {
            Destination = FindConfigurationInCommandLineArguments(new[] { "-d", "--destination" }, arguments);
            Release = FindConfigurationInCommandLineArguments(new[] { "-r", "--release" }, arguments);
            CheckForShowName = arguments.ToLower().Contains("--showname");
        }

        private static string FindConfigurationInCommandLineArguments(IEnumerable<string> parameterName,
            string arguments)
        {
            foreach (var parameter in parameterName)
            {
                var match = Regex.Match(arguments, parameter + " (.*?)(-[drs-]|$)", RegexOptions.IgnoreCase);
                if (match.Groups.Count > 1 && match.Groups[1].Captures.Count > 0)
                {
                    return match.Groups[1].Captures[0].Value.Trim().Replace("\"","");
                }
            }
            return string.Empty;
        }
    }
}