namespace OOPSpotiflixV2
{
    internal sealed class Movie : Media
    {
        public string GetLength()
        {
            return Length.ToString("hh:mm");
        }
        public string GetReleaseDate()
        {
            return ReleaseDate.ToString("D");
        }
    }
}