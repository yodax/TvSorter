namespace TvSorter.ReleaseInformation
{
    internal static class FormattingExtensions
    {
        public static string Pad(this int valueToPad, int numberOfZerosToPadWith)
        {
            var paddedString = valueToPad.ToString();

            while (paddedString.Length < numberOfZerosToPadWith)
            {
                paddedString = "0" + paddedString;
            }

            return paddedString;
        }
    }
}