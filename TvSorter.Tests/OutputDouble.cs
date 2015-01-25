namespace TvSorter.Tests
{
    using System;
    using Output;

    internal class OutputDouble : IOutput
    {
        public string Lines { get; private set; }

        public void AddLine(string line)
        {
            if (!string.IsNullOrEmpty(Lines))
                Lines += Environment.NewLine;

            Lines += line;
        }
    }
}