namespace TvSorter
{
    using System;
    using System.Text.RegularExpressions;

    public static class CleanReleaseName
    {
        public static ShowInfo For(string inputReleaseName)
        {
            var lowerCaseInput = inputReleaseName.ToLower();
            return new ShowInfo
            {
                ReleaseName = inputReleaseName,
                Name = ExtractShowName(lowerCaseInput),
                Season = ExtractSeason(lowerCaseInput),
                Episode = ExtractEpisode(lowerCaseInput),
                ReleaseGroup = ExtractReleaseGroup(lowerCaseInput),
                Quality = ExtractQuality(lowerCaseInput)
            };
        }

        private static string ExtractQuality(string releaseName)
        {
            var quality = ExtractStringFrom(releaseName, @"e\d\d\.(.*)-");

            return quality.Replace("hdtv", "HDTV");
        }

        private static string ExtractReleaseGroup(string releaseName)
        {
            return ExtractStringFrom(releaseName, @"-(.*)").ToUpper();
        }

        private static int ExtractEpisode(string releaseName)
        {
            return ExtractIntegerFrom(releaseName, @"\.s\d\de(\d\d)");
        }

        private static int ExtractSeason(string releaseName)
        {
            return ExtractIntegerFrom(releaseName, @"\.s(\d\d)e");
        }

        private static int ExtractIntegerFrom(string releaseName, string regexWithSingleGroup)
        {
            return Convert.ToInt32(Regex.Match(releaseName, regexWithSingleGroup).Groups[1].Captures[0].Value);
        }

        private static string ExtractShowName(string releaseName)
        {
            var lowerCaseShowName = ExtractStringFrom(releaseName, @"(.*)\.s\d\d");

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