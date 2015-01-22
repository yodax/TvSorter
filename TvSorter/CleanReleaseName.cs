namespace TvSorter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public static class CleanReleaseName
    {
        private static readonly Dictionary<string, string> QualityFormatting = new Dictionary<string, string>
        {
            {"720P", "720p"},
            {"1080P", "1080p"},
            {"X264", "x264"},
            {"WEB.DL", "WEB-DL"},
            {"WEB.RIP", "WEB-RIP"},
            {"XVID", "XviD"}
        };

        private static readonly Dictionary<string, string> DefaultReplacementsInReleaseName = new Dictionary
            <string, string>
        {
            {" ", "."},
            {"web-dl", "web.dl"},
            {"web-rip", "web.rip"}
        };

        public static ShowInfo For(string inputReleaseName)
        {
            var releaseName = inputReleaseName.ToLower();

            releaseName = DefaultReplacementsInReleaseName.Aggregate(releaseName,
                (current, stringToReplace) => current.Replace(stringToReplace.Key, stringToReplace.Value));

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
            return Regex.Replace(releaseName, @"\.part\.\d{1,3}", ".s01e" + partNumber);
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

            return QualityFormatting.Aggregate(quality,
                (current, qualityToReplace) => current.Replace(qualityToReplace.Key, qualityToReplace.Value));
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

        private static string UppercaseWords(string stringToConvertToUpperCaseWords)
        {
            var eachWord = stringToConvertToUpperCaseWords.Split('.');
            var eachUpperCaseWord = new List<string>();
            eachWord.ToList().ForEach(word => eachUpperCaseWord.Add(word[0].ToString().ToUpper() + word.Substring(1)));
            return string.Join(".", eachUpperCaseWord);
        }
    }
}