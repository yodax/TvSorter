namespace TvSorter
{
    public interface IOutput
    {
        string Lines { get; }
        void AddLine(string line);
    }
}