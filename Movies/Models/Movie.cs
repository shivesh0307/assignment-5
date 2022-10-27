namespace Movies.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int ReleaseYear { get; set; }
        public string Lang { get; set; }
        public string Director { get; set; }
        public string Actor { get; set; }
    }
}
