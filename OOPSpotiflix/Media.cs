using OOPSpotiflixV2;
namespace OOPSpotiflixV2
{
    public abstract class Media
    {
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public DateTime Length { get; set; }
        public DateTime ReleaseDate { get; set; } = DateTime.Today;
        public string? WWW { get; set; }

    }
}

