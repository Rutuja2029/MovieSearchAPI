using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace MovieSearchAPI.DataModels
{
    public class MovieSearchContext:DbContext
    {
        public MovieSearchContext(DbContextOptions<MovieSearchContext> options):base(options)
        {

                
        }

        public DbSet<Movie> Movie { get; set; }    
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Language> Language{ get; set; }
        public DbSet<UserData> UserData { get; set; }
        public DbSet<List> List { get; set; }
        public DbSet<WatchList> WatchList { get; set; }


    }
}
