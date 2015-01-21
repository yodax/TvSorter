namespace TvSorter.Tests
{
    using FluentAssertions;
    using TechTalk.SpecFlow;

    [Binding]
    public class CleanUpReleaseNameSteps
    {
        private string inputReleaseName;
        private ShowInfo showInfo;

        [Given(@"an input of (.*)")]
        public void GivenAnInputOf(string inputReleaseName)
        {
            this.inputReleaseName = inputReleaseName;
        }

        [When(@"clean up the release name")]
        public void WhenCleanUpTheReleaseName()
        {
            showInfo = CleanReleaseName.For(inputReleaseName);
        }

        [Then(@"the new name should be (.*)")]
        public void ThenTheNewNameShouldBe(string expectedReleaseName)
        {
            showInfo.ReleaseName.Should().Be(expectedReleaseName);
        }

        [Then(@"the show name should be (.*)")]
        public void ThenTheShowNameShouldBeCristela(string expectedShowName)
        {
            showInfo.Name.Should().Be(expectedShowName);
        }

        [Then(@"the season should be (.*)")]
        public void ThenTheSeasonShouldBe(int seasonNumber)
        {
            showInfo.Season.Should().Be(seasonNumber);
        }

        [Then(@"the episode should be (.*)")]
        public void ThenTheEpisodeShouldBe(int episodeNumber)
        {
            showInfo.Episode.Should().Be(episodeNumber);
        }

        [Then(@"the release group should be (.*)")]
        public void ThenTheReleaseGroupShouldBe(string releaseGroup)
        {
            showInfo.ReleaseGroup.Should().Be(releaseGroup);
        }

        [Then(@"the quality should be (.*)")]
        public void ThenTheQualityShouldBe(string quality)
        {
            showInfo.Quality.Should().Be(quality);
        }
    }
}