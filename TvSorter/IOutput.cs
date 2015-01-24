namespace TvSorter
{
    using System.Collections.Generic;

    public interface IOutput
    {
        string Lines { get; }
        void AddLine(string line);
    }
}