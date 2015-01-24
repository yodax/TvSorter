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

        public MoveRelease(IFileSystem fileSystem, IConfiguration configuration, IOutput output)
        {
            this.configuration = configuration;
            this.output = output;
            this.fileSystem = fileSystem;
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

            foreach (
                var file in
                    fileSystem.Directory.GetFiles(releaseDirectory)
                        .Where(
                            IsOfAllowedExtension))
            {
                var extension = ExtensionOfFileName(file);
                var finalDestination = destination.Replace("{Extension}", extension);
                fileSystem.Directory.CreateDirectory(Path.GetDirectoryName(finalDestination));
                fileSystem.File.Move(file, finalDestination);
            }

            fileSystem.Directory.Delete(releaseDirectory, true);
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
}