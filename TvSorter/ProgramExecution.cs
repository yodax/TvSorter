namespace TvSorter
{
    using Configuration;

    public class ProgramExecution
    {
        private readonly IResolve resolve;

        public ProgramExecution(IResolve resolve)
        {
            this.resolve = resolve;
        }

        public void Execute()
        {
            var configuration = resolve.For<IConfiguration>();

            if (configuration.IsValid)
            {
                if (!configuration.CheckForShowName)
                {
                    var moveRelease = resolve.For<MoveRelease>();
                    moveRelease.From(configuration.Release);
                }
                else
                {
                    var showNameFinder = resolve.For<ShowNameFinder>();
                    showNameFinder.Find(configuration.Release);
                }
            }
        }
    }
}