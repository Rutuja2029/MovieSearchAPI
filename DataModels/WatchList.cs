using System;

namespace MovieSearchAPI.DataModels
{
    public class WatchList
    {
        public Guid Id { get; set; }
        public Guid ListId { get; set; }
        public Guid MovieId { get; set; }   
        public string MovieName { get; set; }

        public string ListName { get; set; }
        //Navigational Property
       // public Movie Movie { get; set; }
        //public List List { get; set; }
    }
}
