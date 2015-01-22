namespace TvSorter
{
    using System;
    using System.Text.RegularExpressions;

    public static class CleanReleaseName
    {
        public static ShowInfo For(string inputReleaseName)
        {
            var releaseName = inputReleaseName.ToLower();

            releaseName = releaseName.Replace(' ', '.');
            releaseName = releaseName.Replace("web-dl", "web.dl");
            releaseName = releaseName.Replace("web-rip", "web.rip");


            if (!ContainsSeasonEpisodeString(releaseName))
            {
                if (ContainsPartString(releaseName))
                {
                    releaseName = ConvertPartStringToSeasonEpisode(releaseName);
                }
            }

            if (!ContainsReleasGroup(releaseName))
            {
                releaseName = releaseName + "-NOGROUP";
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

        private static bool ContainsReleasGroup(string releaseName)
        {
            return Regex.IsMatch(releaseName, @"-\w*");
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
            var quality = ExtractStringFrom(releaseName, @"e\d{1,3}.(.*)-").ToUpper();

            quality = quality.Replace("720P", "720p");
            quality = quality.Replace("1080P", "1080p");
            quality = quality.Replace("X264", "x264");
            quality = quality.Replace("WEB.DL", "WEB-DL");
            quality = quality.Replace("WEB.RIP", "WEB-RIP");
            quality = quality.Replace("XVID", "XviD");

            return quality;
        }

        private static string ExtractReleaseGroup(string releaseName)
        {
            var releaseGroup = ExtractStringFrom(releaseName, @"[^b]-(.*)").ToUpper();

            return string.IsNullOrEmpty(releaseGroup) ? "NOGROUP" : releaseGroup;
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

            return UppercaseWords(lowerCaseShowName).Replace('.', ' ');
        }

        private static string ExtractStringFrom(string inputReleaseName, string regexWithSingleGroup)
        {
            var match = Regex.Match(inputReleaseName, regexWithSingleGroup);
            return match.Groups.Count == 1 ? "" : match.Groups[1].Captures[0].Value;
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
                if (array[i - 1] == '.')
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