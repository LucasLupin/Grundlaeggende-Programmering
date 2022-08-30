    namespace OOPSpotiflixV2
    {
        internal sealed class Music : Media
        {
        public string? Artist { get; set; }
        public string? Album { get; set; }

        public List<Song> Songs { get; set; } = new List<Song>();

        public string GetLength()
            {
                return Length.ToString("hh:mm");
            }
            public string GetReleaseDate()
            {
                return ReleaseDate.ToString("D");
            }
        }

        internal class Song : Media
        {
        public string? Artist { get; set; }
        public string? Album { get; set; }
        public string? songname { get; set; }

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

