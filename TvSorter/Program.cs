namespace TvSorter
{
    using Configuration;

    public static class Program
    {
        public static void Main(string[] args)
        {
            new ProgramExecution(new Resolve(new ConfigurationSupplied(args))).Execute();
        }
    }
}