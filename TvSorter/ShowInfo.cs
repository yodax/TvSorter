namespace TvSorter
{
    using System;

    public class ShowInfo
    {
        public string ReleaseName
        {
            get
            {
                return String.Format("{0}.{1}.{2}-{3}", Name.Replace(' ', '.'), SeasonEpisode,
                    Quality, ReleaseGroup);
            }
        }

        public string Name { get; set; }
        public int Season { get; set; }
        public int Episode { get; set; }
        public string ReleaseGroup { get; set; }
        public string Quality { get; set; }

        public string SeasonEpisode
        {
            get { return "S" + Season.Pad(2) + "E" + Episode.Pad(2); }
        }
    }
}