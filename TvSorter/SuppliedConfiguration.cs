namespace TvSorter
{
    public abstract class SuppliedConfiguration : IConfiguration
    {
        public string Destination { get; protected set; }

        public string Release { get; protected set; }
    }
}