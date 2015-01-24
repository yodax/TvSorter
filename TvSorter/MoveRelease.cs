namespace TvSorter
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Abstractions;
    using System.Linq;

    public class MoveRelease : IMoveRelease
    {
        private readonly IEnumerable<string> allowedExtension = new List<string> {"mkv", "avi", "mp4", "nfo", "srt", "sub", "idx"};
        private readonly IConfiguration configuration;
        private readonly IFileSystem fileSystem;
        private readonly IEnumerable<string> mediaTypes = new List<string> {"mkv", "avi", "mp4"};
        private readonly IOutput output;
        private readonly List<FileMovePair> filesThatWhereMoved;  

        public MoveRelease(IFileSystem fileSystem, IConfiguration configuration, IOutput output)
        {
            this.configuration = configuration;
            this.output = output;
            this.fileSystem = fileSystem;
            filesThatWhereMoved = new List<FileMovePair>();
        }

        public void From(string releaseDirectory)
        {
            if (!OnlyOneMediaFilePresentIn(releaseDirectory))
            {
                output.AddLine("More than one media file detected in " + releaseDirectory);
                return; 
            }

            var videoFile = GetMediaFile(releaseDirectory);

            if (string.IsNullOrEmpty(videoFile))
            {
                output.AddLine("No media files detected in " + releaseDirectory);
                return;
            }

            var showInfo = CleanReleaseName.For(Path.GetFileNameWithoutExtension(videoFile));
            var destination = DetermineFileFileNameUsingShowInformation(showInfo, configuration.Destination);

            AddHeaderToOutput(releaseDirectory, showInfo, destination);

            var nfoFileContents = "";

            foreach (
                var file in
                    fileSystem.Directory.GetFiles(releaseDirectory)
                        .Where(
                            IsOfAllowedExtension))
            {
                var extension = ExtensionOfFileName(file);
                var finalDestination = destination.Replace("{Extension}", extension);

                if (extension.Equals("nfo", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (!string.IsNullOrEmpty(nfoFileContents))
                        nfoFileContents += Environment.NewLine;
                    nfoFileContents += fileSystem.File.ReadAllText(file);
                }

                fileSystem.Directory.CreateDirectory(Path.GetDirectoryName(finalDestination));
                
                MoveFileToDestination(file, finalDestination);
            }
            FinalizeFileToMoveOutput();

            AddFilesNotMovedToOutput(releaseDirectory);

            AddNfoToOutput(nfoFileContents);

            fileSystem.Directory.Delete(releaseDirectory, true);
        }

        private void MoveFileToDestination(string file, string destination)
        {
            var incrementForFileIdentifier = 1;
            var finalDestination = destination;
            while (fileSystem.File.Exists(finalDestination))
            {
                finalDestination = Path.Combine(Path.GetDirectoryName(destination), Path.GetFileNameWithoutExtension(destination) + "." + incrementForFileIdentifier + Path.GetExtension(destination));
                incrementForFileIdentifier++;
            }
            fileSystem.File.Move(file, finalDestination);

            AddFileMoveToOutput(file, finalDestination);
        }

        private void AddNfoToOutput(string nfoFileContents)
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

        private void AddFilesNotMovedToOutput(string releaseDirectory)
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

        private void AddFileMoveToOutput(string file, string finalDestination)
        {
            filesThatWhereMoved.Add(new FileMovePair{Destination = Path.GetFileName(finalDestination), Source = Path.GetFileName(file)});
        }

        private void FinalizeFileToMoveOutput()
        {
            var maximumLength = filesThatWhereMoved.Max(f => f.Source.Length);

            foreach (var fileThatWasMoved in filesThatWhereMoved)
            {
                output.AddLine(string.Format("\t$ {0} => {1}", fileThatWasMoved.Source.PadRight(maximumLength), fileThatWasMoved.Destination));
            }
        }

        private void AddHeaderToOutput(string releaseDirectory, ShowInfo showInfo, string destination)
        {
            output.AddLine("Using filename: " + showInfo.ReleaseName);
            output.AddLine("");
            output.AddLine("Moving files from: " + releaseDirectory);
            output.AddLine("        directory: " + Path.GetDirectoryName(destination));
            output.AddLine("");
            output.AddLine("Moving:");
            output.AddLine("");
        }

        private bool OnlyOneMediaFilePresentIn(string releaseDirectory)
        {
            var mediaCount = mediaTypes.Sum(mediaType => fileSystem.Directory.GetFiles(releaseDirectory, "*." + mediaType).Count());
            return mediaCount <= 1;
        }

        private static string DetermineFileFileNameUsingShowInformation(ShowInfo showInfo,
            string destinationFromConfiguration)
        {
            var destination = destinationFromConfiguration;

            destination = destination.Replace("{ShowName}", showInfo.Name);
            destination = destination.Replace("{SeasonEpisode}", showInfo.SeasonEpisode);
            destination = destination.Replace("{ReleaseName}", showInfo.ReleaseName);

            return destination;
        }

        private bool IsOfAllowedExtension(string file)
        {
            return allowedExtension.Any(
                extension =>
                    extension.Equals(ExtensionOfFileName(file),
                        StringComparison.InvariantCultureIgnoreCase));
        }

        private static string ExtensionOfFileName(string file)
        {
            var extension = Path.GetExtension(file);
            return string.IsNullOrEmpty(extension) ? string.Empty : extension.Substring(1);
        }

        private string GetMediaFile(string releaseDirectory)
        {
            foreach (var mediaType in mediaTypes)
            {
                var mediaFile = GetMediaFileWithExtension(releaseDirectory, "*." +mediaType);
                if (!string.IsNullOrEmpty(mediaFile))
                    return mediaFile;
            }

            return string.Empty;
        }

        private string GetMediaFileWithExtension(string releaseDirectory, string searchPattern)
        {
            var files = fileSystem.Directory.GetFiles(releaseDirectory, searchPattern);
            if (files.Length == 0)
                return String.Empty;

            return files[0];
        }
    }

    internal class FileMovePair
    {
        public string Source { get; set; }
        public string Destination { get; set; }
    }
}