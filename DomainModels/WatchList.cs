using System;

namespace MovieSearchAPI.DomainModels
{
    public class WatchList
    {

        public Guid Id { get; set; }
        public string MovieName { get; set; }
        public Movie Movie { get; set; }
    }
}
