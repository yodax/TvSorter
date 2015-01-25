namespace TvSorter
{
    public interface IConfiguration
    {
        string Destination { get; }
        string Release { get; }
        bool CheckForShowName { get; }
    }
}