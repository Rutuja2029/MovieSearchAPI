using System;

namespace MovieSearchAPI.DomainModels
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

        public Genre Genre { get; set; }
        public Language Language { get; set; }
    }
}
