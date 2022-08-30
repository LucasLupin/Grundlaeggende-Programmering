using System;
namespace OOPSpotiflixV2
{
    internal sealed class Series : Media
    {
        public int Season { get; set; }

        public string GetLength()
        {
            return Length.ToString("hh:mm");
        }
        public string GetReleaseDate()
        {
            return ReleaseDate.ToString("D");
        }

        public List<Episode> Episodes { get; set; } = new();
    }

    internal class Episode : Media
    {
        public string? TitleEpisode { get; set; }
        public int Season { get; set; }
        public int EpisodeNum { get; set; }

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

