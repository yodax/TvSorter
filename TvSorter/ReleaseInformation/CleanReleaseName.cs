namespace TvSorter.ReleaseInformation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public static class CleanReleaseName
    {
        private static readonly Dictionary<string, string> QualityFormatting = new Dictionary<string, string>
        {
            {"480P", "480p"},
            {"720P", "720p"},
            {"1080P", "1080p"},
            {"X264", "x264"},
            {"WEB.DL", "WEB-DL"},
            {"WEB.RIP", "WEB-RIP"},
            {"XVID", "XviD"},
            {"DVDRIP", "DVDRip"},
            {"BLURAY", "BluRay"}
        };

        private static readonly List<string> StartingQualityIndicators = new List<string>
        {
            "convert",
            "native",
            "proper",
            "real",
            "repack",
            "dirfix",
            "nfofix",
            "read.nfo",
            "internal",
            "subbed",
            "dubbed",
            "1080p",
            "720p",
            "480p",
            "hdtv",
            "dsr",
            "ws",
            "bdrip",
            "bluray",
            "dvdrip",
            "pdtv",
            "x264",
            "H.264"
        };

        private static readonly Dictionary<string, string> DefaultReplacementsInReleaseName = new Dictionary
            <string, string>
        {
            {" ", "."},
            {".-.", "."},
            {"..", "."},
            {"(", ""},
            {")", ""},
            {"web-dl", "web.dl"},
            {"web-rip", "web.rip"},
            {"&", "and"}
        };

        private static readonly List<string> WordsToKeepInLowerCase = new List<string>
        {
            "and",
            "the"
        };

        private static readonly Dictionary<string, int> RomanNumerals = new Dictionary
            <string, int>
        {
            {"i", 1},
            {"ii", 2},
            {"iii", 3},
            {"iv", 4},
            {"v", 5},
            {"vi", 6},
            {"vii", 7},
            {"viii", 8},
            {"ix", 9},
            {"x", 10},
            {"xi", 11},
            {"xii", 12},
            {"xiii", 13}
        };

        public static ShowInfo For(string inputReleaseName)
        {
            try
            {
                var releaseName = inputReleaseName.ToLower();

                releaseName = DefaultReplacementsInReleaseName.Aggregate(releaseName,
                    (current, stringToReplace) => current.Replace(stringToReplace.Key, stringToReplace.Value));

                releaseName = RemoveEverythingBetweenBracketsExceptQuality(releaseName);

                if (!ContainsSeasonEpisodeString(releaseName))
                {
                    if (ContainsFullSeasonAndEpisodeString(releaseName))
                    {
                        releaseName = ConvertFullSeasonAndEpisodeString(releaseName);
                    }
                    if (ContainsDecimalPartString(releaseName) && !ContainsSeasonEpisodeString(releaseName))
                    {
                        releaseName = ConvertDecimalPartStringToSeasonEpisode(releaseName);
                    }
                    if (ContainsRomanNumeralPartString(releaseName))
                    {
                        releaseName = ConvertRomanNumeralPartStringToSeasonEpisode(releaseName);
                    }
                    if (ContainsXSeasonEpisodeString(releaseName))
                    {
                        releaseName = ConvertXSeasonToSeasonEpidose(releaseName);
                    }
                    if (ContainsThreeDecimalEpisodeString(releaseName))
                    {
                        releaseName = ConvertThreeDecimalEpisodeString(releaseName);
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
                    Quality = ExtractQuality(releaseName),
                    Parseable = true
                };
            }
            catch 
            {
                return new ShowInfo
                {
                    Parseable = false
                };
            }
        }

        private static bool ContainsFullSeasonAndEpisodeString(string releaseName)
        {
            return Regex.IsMatch(releaseName, @"season\.\d{1,2}\.episode\.\d{1,2}\.");

        }

        private static string ConvertFullSeasonAndEpisodeString(string releaseName)
        {
            var match = Regex.Match(releaseName, @"season\.(\d{1,2})\.episode\.(\d{1,2})\.");
            var season = match.Groups[1].Captures[0];
            var episode = match.Groups[2].Captures[0];
            return Regex.Replace(releaseName, @"season\.\d{1,2}\.episode\.\d{1,2}\.", "s" + season + "e" + episode + ".");
        }

        private static string ConvertThreeDecimalEpisodeString(string releaseName)
        {
            var match = Regex.Match(releaseName, @"\.(\d{1})(\d{2})\.");
            var season = match.Groups[1].Captures[0];
            var episode = match.Groups[2].Captures[0];
            return Regex.Replace(releaseName, @"\.\d{3}\.", ".s" + season + "e" + episode + ".");
        }

        private static bool ContainsThreeDecimalEpisodeString(string releaseName)
        {
            return Regex.IsMatch(releaseName, @"\.\d{3}\.");
        }

        private static string RemoveEverythingBetweenBracketsExceptQuality(string releaseName)
        {
            var newReleaseName = releaseName;

            foreach (var qualityIndicator in StartingQualityIndicators)
            {
                newReleaseName = Regex.Replace(newReleaseName, @"\[" + qualityIndicator + @"\]", qualityIndicator);
            }

            newReleaseName = Regex.Replace(newReleaseName, @"\.{0,1}\[.*?\]", "");

            return newReleaseName;
        }

        private static string ConvertXSeasonToSeasonEpidose(string releaseName)
        {
            var match = Regex.Match(releaseName, @"\.(\d{1,2})x(\d{1,2})\.");
            var season = match.Groups[1].Captures[0];
            var episode = match.Groups[2].Captures[0];
            return Regex.Replace(releaseName, @"\.\d{1,2}x\d{1,2}\.", ".s" + season + "e" + episode + ".");
        }

        private static bool ContainsXSeasonEpisodeString(string releaseName)
        {
            return Regex.IsMatch(releaseName, @"\.\d{1,2}x\d{1,2}\.");
        }

        private static string ConvertRomanNumeralPartStringToSeasonEpisode(string releaseName)
        {
            var partNumberRomanNumeral = Regex.Match(releaseName, @"\.part\.([ivx]{1,4})\.").Groups[1].Captures[0].Value;

            return Regex.Replace(releaseName, @"\.part\.[ivx]{1,4}\.",
                ".s01e" + RomanNumerals[partNumberRomanNumeral] + ".");
        }

        private static bool ContainsRomanNumeralPartString(string releaseName)
        {
            return Regex.IsMatch(releaseName, @"\.part\.[ivx]{1,4}\.");
        }

        private static bool ContainsReleasGroup(string releaseName)
        {
            return Regex.IsMatch(releaseName, @"-\w*");
        }

        private static string ConvertDecimalPartStringToSeasonEpisode(string releaseName)
        {
            var partNumber = Convert.ToInt32(Regex.Match(releaseName, @"\.part\.(\d{1,3})").Groups[1].Captures[0].Value);
            return Regex.Replace(releaseName, @"\.part\.\d{1,3}", ".s01e" + partNumber);
        }

        private static bool ContainsDecimalPartString(string releaseName)
        {
            return Regex.IsMatch(releaseName, @"\.part\.\d{1,3}");
        }

        private static bool ContainsSeasonEpisodeString(string releaseName)
        {
            return Regex.IsMatch(releaseName, @"s\d{1,3}e\d{1,3}\.");
        }

        private static string ExtractQuality(string releaseName)
        {
            var quality = ExtractStringFrom(releaseName, @"e\d{1,3}.(.*)-").ToUpper();

            var matchedQualities = StartingQualityIndicators.Select(qualityIndicator => quality.IndexOf(qualityIndicator, StringComparison.InvariantCultureIgnoreCase))
                .Where(index => index >= 0)
                .ToList();

            if (matchedQualities.Any())
            {
                var qualityStartsFrom =
                    matchedQualities
                        .Min();

                quality = quality.Substring(qualityStartsFrom);
            }

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
            if (string.IsNullOrEmpty(stringToConvertToUpperCaseWords))
                return "";

            var eachWord = stringToConvertToUpperCaseWords.Split('.');
            var eachUpperCaseWord = new List<string>();
            eachWord.ToList().ForEach(word =>
            {
                if (WordsToKeepInLowerCase.Contains(word))
                    eachUpperCaseWord.Add(word);
                else
                    eachUpperCaseWord.Add(UpperCaseWord(word));
            });

            var firstWord = eachUpperCaseWord[0];
            eachUpperCaseWord[0] = UpperCaseWord(firstWord);

            return string.Join(".", eachUpperCaseWord);
        }

        private static string UpperCaseWord(string word)
        {
            return word[0].ToString().ToUpper() + word.Substring(1);
        }
    }
}