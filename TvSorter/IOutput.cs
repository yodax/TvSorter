namespace TvSorter
{
    using System.Collections.Generic;

    public interface IOutput
    {
        IEnumerable<string> Lines { get; }
        void AddLine(string line);
    }
}