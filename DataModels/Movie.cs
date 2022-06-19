using System;


namespace MovieSearchAPI.DataModels
{
    public class Movie
    {
        public Guid Id { get; set; }    
        public string MovieName { get; set; }
        public int ReleaseDate { get; set; }
        public Double ImdbRating { get; set; }
        public string MovieCast { get; set; }
        public Guid GenreId { get; set; }
        public Guid LanguageId { get; set; }

        // Navigational Property
        public Genre Genre { get; set; }
        public Language Language { get; set; }

    }
}
