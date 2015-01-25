namespace TvSorter
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Abstractions;
    using System.Linq;

    public class MoveRelease : IMoveRelease
    {
        private readonly IEnumerable<string> allowedExtension = new List<string>
        {
            "mkv",
            "avi",
            "mp4",
            "nfo",
            "srt",
            "sub",
            "idx"
        };

        private readonly IConfiguration configuration;
        private readonly IFileSystem fileSystem;
        private readonly MoveReleaseOutput moveReleaseOutput;
        private readonly ExtractShowInfoFromRelease extractShowInfoFromRelease;

        public MoveRelease(IFileSystem fileSystem, IConfiguration configuration,
            MoveReleaseOutput moveReleaseOutput, ExtractShowInfoFromRelease showInfoFromRelease)
        {
            extractShowInfoFromRelease = showInfoFromRelease;
            this.configuration = configuration;
            this.fileSystem = fileSystem;
            this.moveReleaseOutput = moveReleaseOutput;
        }

        public void From(string releaseDirectory)
        {
            if (!extractShowInfoFromRelease.IsReleaseValid(releaseDirectory))
                return;
            var showInfo = extractShowInfoFromRelease.GetShowInfoForRelease(releaseDirectory);
            var destination = DetermineFileFileNameUsingShowInformation(showInfo, configuration.Destination);

            moveReleaseOutput.AddHeaderToOutput(releaseDirectory, showInfo, destination);

            var nfoFileContents = "";

            foreach (
                var file in
                    fileSystem.Directory.GetFiles(releaseDirectory)
                        .Where(
                            IsOfAllowedExtension))
            {
                var extension = ExtensionOfFileName(file);
                var finalDestination = destination.Replace("{Extension}", extension);

                if (IsCurrentFileAnInfoFile(extension))
                {
                    if (WasThereAPreviousInfoFileLoaded(nfoFileContents))
                    {
                        nfoFileContents += AddInfoFileSeperator();
                    }
                    nfoFileContents += ReadInfoFileContents(file);
                }

                CreateDestinationDirectory(finalDestination);

                MoveFileToDestination(file, finalDestination);
            }

            moveReleaseOutput.FinalizeFileToMoveOutput();
            moveReleaseOutput.AddFilesNotMovedToOutput(releaseDirectory);
            moveReleaseOutput.AddNfoToOutput(nfoFileContents);

            fileSystem.Directory.Delete(releaseDirectory, true);
        }

        private void CreateDestinationDirectory(string finalDestination)
        {
            fileSystem.Directory.CreateDirectory(Path.GetDirectoryName(finalDestination));
        }

        private string ReadInfoFileContents(string file)
        {
            return fileSystem.File.ReadAllText(file);
        }

        private static string AddInfoFileSeperator()
        {
            return Environment.NewLine + Environment.NewLine + "=====================" + Environment.NewLine +
                   Environment.NewLine;
        }

        private static bool WasThereAPreviousInfoFileLoaded(string nfoFileContents)
        {
            return !string.IsNullOrEmpty(nfoFileContents);
        }

        private static bool IsCurrentFileAnInfoFile(string extension)
        {
            return extension.Equals("nfo", StringComparison.InvariantCultureIgnoreCase);
        }

        private void MoveFileToDestination(string file, string destination)
        {
            var incrementForFileIdentifier = 1;
            var finalDestination = destination;
            while (fileSystem.File.Exists(finalDestination))
            {
                var destinationDirectory = Path.GetDirectoryName(destination) ?? "";

                finalDestination = Path.Combine(destinationDirectory,
                    Path.GetFileNameWithoutExtension(destination) + "." + incrementForFileIdentifier +
                    Path.GetExtension(destination));
                incrementForFileIdentifier++;
            }
            fileSystem.File.Move(file, finalDestination);

            moveReleaseOutput.AddFileMoveToOutput(file, finalDestination);
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
    }

    internal class FileMovePair
    {
        public string Source { get; set; }
        public string Destination { get; set; }
    }
}