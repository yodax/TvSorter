namespace TvSorter.Configuration
{
    public interface IConfiguration
    {
        string Destination { get; }
        string Release { get; }
        bool CheckForShowName { get; }
        bool IsValid { get; }
    }
}