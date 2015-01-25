namespace TvSorter
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Abstractions;
    using System.Linq;
    using Output;
    using ReleaseInformation;

    public class ReleaseInformationOnFileSystem
    {
        private readonly IFileSystem fileSystem;
        private readonly IOutput output;
        private readonly IEnumerable<string> mediaTypes = new List<string> { "mkv", "avi", "mp4" };


        public ReleaseInformationOnFileSystem(IFileSystem fileSystem, IOutput output)
        {
            this.output = output;
            this.fileSystem = fileSystem;
        }

        public bool IsReleaseValid(string releaseDirectory)
        {
            if (!fileSystem.Directory.Exists(releaseDirectory))
            {
                output.AddLine("Release directory doesn't exist " + releaseDirectory);
                return false;
            }

            if (!OnlyOneMediaFilePresentIn(releaseDirectory))
            {
                output.AddLine("More than one media file detected in " + releaseDirectory);
                return false;
            }

            var videoFile = GetMediaFile(releaseDirectory);

            if (string.IsNullOrEmpty(videoFile))
            {
                output.AddLine("No media files detected in " + releaseDirectory);
                return false;
            }

            return true;
        }

        public ShowInfo GetShowInfo(string releaseDirectory)
        {
            var videoFile = GetMediaFile(releaseDirectory);

            var showInfoFromFile =  CleanReleaseName.For(Path.GetFileNameWithoutExtension(videoFile));

            return !showInfoFromFile.Parseable ? CleanReleaseName.For(Path.GetFileName(releaseDirectory)) : showInfoFromFile;
        }

        private bool OnlyOneMediaFilePresentIn(string releaseDirectory)
        {
            var mediaCount = mediaTypes.Sum(mediaType => fileSystem.Directory.GetFiles(releaseDirectory, "*." + mediaType).Count());
            return mediaCount <= 1;
        }

        private string GetMediaFileWithExtension(string releaseDirectory, string searchPattern)
        {
            var files = fileSystem.Directory.GetFiles(releaseDirectory, searchPattern);
            if (files.Length == 0)
                return String.Empty;

            return files[0];
        }
        private string GetMediaFile(string releaseDirectory)
        {
            foreach (var mediaType in mediaTypes)
            {
                var mediaFile = GetMediaFileWithExtension(releaseDirectory, "*." + mediaType);
                if (!string.IsNullOrEmpty(mediaFile))
                    return mediaFile;
            }

            return string.Empty;
        }
    }
}