namespace TvSorter
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Abstractions;
    using System.Linq;

    public class MoveReleaseOutput
    {
        private readonly List<FileMovePair> filesThatWhereMoved;
        private readonly IOutput output;
        private readonly IFileSystem fileSystem;

        public MoveReleaseOutput(IOutput output, IFileSystem fileSystem)
        {
            this.fileSystem = fileSystem;
            this.output = output;
            filesThatWhereMoved = new List<FileMovePair>();
        }

        public void AddNfoToOutput(string nfoFileContents)
        {
            if (string.IsNullOrEmpty(nfoFileContents)) return;

            output.AddLine("");
            output.AddLine("NFO file:");
            output.AddLine("");
            foreach (var lineInNfoFile in nfoFileContents.Split(new []{Environment.NewLine, "\n"}, StringSplitOptions.None))
            {
                output.AddLine("\t$ " + lineInNfoFile);
            }
        }

        public void AddFilesNotMovedToOutput(string releaseDirectory)
        {
            var filesNotMoved = fileSystem.Directory.GetFiles(releaseDirectory);

            if (!filesNotMoved.Any())
                return;

            output.AddLine("");
            output.AddLine("Not moving:");
            output.AddLine("");

            foreach (
                var file in
                    filesNotMoved)
            {
                output.AddLine(string.Format("\t$ {0}", Path.GetFileName(file)));
            }
        }

        public void AddFileMoveToOutput(string file, string finalDestination)
        {
            filesThatWhereMoved.Add(new FileMovePair{Destination = Path.GetFileName(finalDestination), Source = Path.GetFileName(file)});
        }

        public void FinalizeFileToMoveOutput()
        {
            var maximumLength = filesThatWhereMoved.Max(f => f.Source.Length);

            foreach (var fileThatWasMoved in filesThatWhereMoved)
            {
                output.AddLine(string.Format("\t$ {0} => {1}", fileThatWasMoved.Source.PadRight(maximumLength), fileThatWasMoved.Destination));
            }
        }

        public void AddHeaderToOutput(string releaseDirectory, ShowInfo showInfo, string destination)
        {
            output.AddLine("Using filename: " + showInfo.ReleaseName);
            output.AddLine("");
            output.AddLine("Moving files from: " + releaseDirectory);
            output.AddLine("        directory: " + Path.GetDirectoryName(destination));
            output.AddLine("");
            output.AddLine("Moving:");
            output.AddLine("");
        }
    }
}