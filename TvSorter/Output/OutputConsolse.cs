namespace TvSorter.Output
{
    using System;

    public class OutputConsolse : IOutput
    {
        public string Lines
        {
            get { throw new System.NotImplementedException(); }
        }

        public void AddLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}