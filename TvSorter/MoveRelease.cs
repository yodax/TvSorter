namespace TvSorter
{
    using System;
    using System.IO;
    using System.IO.Abstractions;

    public class MoveRelease : IMoveRelease
    {
        private readonly IConfiguration configuration;
        private readonly IFileSystem fileSystem;
        private readonly IOutput output;

        public MoveRelease(IFileSystem fileSystem, IConfiguration configuration, IOutput output)
        {
            this.configuration = configuration;
            this.output = output;
            this.fileSystem = fileSystem;
        }

        public void From(string releaseDirectory)
        {
            var videoFile = GetFirstMediaFile(releaseDirectory);

            if (string.IsNullOrEmpty(videoFile))
            {
                output.AddLine("No media files detected in " + releaseDirectory);
                return;
            }

            var showInfo = CleanReleaseName.For(Path.GetFileNameWithoutExtension(videoFile));
            var destination = configuration.Destination;

            destination = destination.Replace("{ShowName}", showInfo.Name);
            destination = destination.Replace("{SeasonEpisode}",
                "S" + showInfo.Season.Pad(2) + "E" + showInfo.Episode.Pad(2));
            destination = destination.Replace("{ReleaseName}", showInfo.ReleaseName);

            foreach (var file in fileSystem.Directory.GetFiles(releaseDirectory))
            {
                var extension = Path.GetExtension(file).Substring(1);
                var finalDestination = destination.Replace("{Extension}", extension);
                fileSystem.Directory.CreateDirectory(Path.GetDirectoryName(finalDestination));
                fileSystem.File.Move(file, finalDestination);
            }

            fileSystem.Directory.Delete(releaseDirectory);
        }

        private string GetFirstMediaFile(string releaseDirectory)
        {
            var firstMkvFile = GetFirstMediaFileWithExtension(releaseDirectory, "*.mkv");
            if (!string.IsNullOrEmpty(firstMkvFile))
                return firstMkvFile;

            var firstMp4File = GetFirstMediaFileWithExtension(releaseDirectory, "*.mp4");
            if (!string.IsNullOrEmpty(firstMp4File))
                return firstMp4File;

            var firstAviFile = GetFirstMediaFileWithExtension(releaseDirectory, "*.avi");
            if (!string.IsNullOrEmpty(firstAviFile))
                return firstAviFile;

            return string.Empty;
        }

        private string GetFirstMediaFileWithExtension(string releaseDirectory, string searchPattern)
        {
            var files = fileSystem.Directory.GetFiles(releaseDirectory, searchPattern);
            if (files.Length == 0)
                return String.Empty;

            return files[0];
        }
    }
}