namespace TvSorter.Tests
{
    using System.Collections.Generic;

    class OutputDouble : IOutput
    {
        private readonly List<string> lines;

        public OutputDouble()
        {
            lines = new List<string>();
        }

        public IEnumerable<string> Lines
        {
            get { return lines; }
        }

        public void AddLine(string line)
        {
            lines.Add(line);
        }
    }
}