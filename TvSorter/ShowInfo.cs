namespace TvSorter
{
    public class ShowInfo
    {
        public string ReleaseName
        {
            get { return string.Format("{0}.S{1}E{2}.{3}-{4}", Name, Season.Pad(2), Episode.Pad(2), Quality, ReleaseGroup); } 
        }

        public string Name { get; set; }
        public int Season { get; set; }
        public int Episode { get; set; }
        public string ReleaseGroup { get; set; }
        public string Quality { get; set; }
    }
}