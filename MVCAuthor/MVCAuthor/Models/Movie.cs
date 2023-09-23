namespace MVCAuthor.Models
{
    public class Movie
    {
        public int ID { set; get; }
        public string Title { set; get; }
        public string Language { set; get; }
        public string Hero { set; get; }
        public string Director { set; get; }
        public string MusicDirector { set; get; }
        public DateOnly ReleaseDate { set; get; }
        public decimal Cost { set; get; }
        public decimal Collection { set; get; }
        public int Review { set; get; }
    }
}
