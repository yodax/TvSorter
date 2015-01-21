namespace TvSorter
{
    using System;
    using System.Text.RegularExpressions;

    public static class CleanReleaseName
    {
        public static ShowInfo For(string inputReleaseName)
        {
            var releaseName = inputReleaseName.ToLower();

            if (!ContainsSeasonEpisodeString(releaseName))
            {
                if (ContainsPartString(releaseName))
                {
                    releaseName = ConvertPartStringToSeasonEpisode(releaseName);
                }
            }
            return new ShowInfo
            {
                Name = ExtractShowName(releaseName),
                Season = ExtractSeason(releaseName),
                Episode = ExtractEpisode(releaseName),
                ReleaseGroup = ExtractReleaseGroup(releaseName),
                Quality = ExtractQuality(releaseName)
            };
        }

        private static string ConvertPartStringToSeasonEpisode(string releaseName)
        {
            var partNumber = Convert.ToInt32(Regex.Match(releaseName, @"\.part\.(\d{1,3})").Groups[1].Captures[0].Value);
            return Regex.Replace(releaseName, @"\.part\.\d{1,3}", ".s01e" + partNumber.ToString());
        }

        private static bool ContainsPartString(string releaseName)
        {
            return Regex.IsMatch(releaseName, @"\.part\.\d{1,3}");
        }

        private static bool ContainsSeasonEpisodeString(string releaseName)
        {
            return Regex.IsMatch(releaseName, @"\.s\d{1,3}e\d{1,3}\.");
        }

        private static string ExtractQuality(string releaseName)
        {
            var quality = ExtractStringFrom(releaseName, @"e\d{1,3}.(.*)-");

            return quality.Replace("hdtv", "HDTV");
        }

        private static string ExtractReleaseGroup(string releaseName)
        {
            return ExtractStringFrom(releaseName, @"-(.*)").ToUpper();
        }

        private static int ExtractEpisode(string releaseName)
        {
            return ExtractIntegerFrom(releaseName, @"\.s\d{1,3}e(\d{1,3})");
        }

        private static int ExtractSeason(string releaseName)
        {
            return ExtractIntegerFrom(releaseName, @"\.s(\d{1,3})e");
        }

        private static int ExtractIntegerFrom(string releaseName, string regexWithSingleGroup)
        {
            return Convert.ToInt32(Regex.Match(releaseName, regexWithSingleGroup).Groups[1].Captures[0].Value);
        }

        private static string ExtractShowName(string releaseName)
        {
            var lowerCaseShowName = ExtractStringFrom(releaseName, @"(.*)\.s\d{1,3}");

            return UppercaseWords(lowerCaseShowName);
        }

        private static string ExtractStringFrom(string inputReleaseName, string regexWithSingleGroup)
        {
            return Regex.Match(inputReleaseName, regexWithSingleGroup).Groups[1].Captures[0].Value;
        }

        private static string UppercaseWords(string value)
        {
            var array = value.ToCharArray();
            // Handle the first letter in the string.
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            // Scan through the letters, checking for spaces.
            // ... Uppercase the lowercase letters following spaces.
            for (var i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }
    }
}