namespace TvSorter
{
    public class ShowNameFinder : IShowNameFinder
    {
        private readonly ExtractShowInfoFromRelease showInfoFromRelease;
        private readonly IOutput output;

        public ShowNameFinder(ExtractShowInfoFromRelease extractShowInfoFromRelease, IOutput output)
        {
            this.output = output;
            showInfoFromRelease = extractShowInfoFromRelease;
        }

        public void Find(string releaseDirectory)
        {
            if (!showInfoFromRelease.IsReleaseValid(releaseDirectory))
                return;

            var showInfo = showInfoFromRelease.GetShowInfoForRelease(releaseDirectory);
            
            output.AddLine(string.Format("{0} {1} {2}", showInfo.Name, showInfo.SeasonEpisode, showInfo.Quality.Replace(".", " ")));
        }
    }
}