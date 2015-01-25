namespace TvSorter
{
    using Output;

    public class ShowNameFinder
    {
        private readonly ReleaseInformationOnFileSystem showInfoFromReleaseInformationOnFileSystem;
        private readonly IOutput output;

        public ShowNameFinder(ReleaseInformationOnFileSystem releaseInformationOnFileSystem, IOutput output)
        {
            this.output = output;
            showInfoFromReleaseInformationOnFileSystem = releaseInformationOnFileSystem;
        }

        public void Find(string releaseDirectory)
        {
            if (!showInfoFromReleaseInformationOnFileSystem.IsReleaseValid(releaseDirectory))
                return;

            var showInfo = showInfoFromReleaseInformationOnFileSystem.GetShowInfo(releaseDirectory);
            
            output.AddLine(string.Format("{0} {1} {2}", showInfo.Name, showInfo.SeasonEpisode, showInfo.Quality.Replace(".", " ")));
        }
    }
}