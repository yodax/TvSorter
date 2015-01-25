namespace TvSorter.Output
{
    public interface IOutput
    {
        string Lines { get; }
        void AddLine(string line);
    }
}