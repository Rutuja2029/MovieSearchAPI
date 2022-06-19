using Microsoft.EntityFrameworkCore;
using MovieSearchAPI.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieSearchAPI.Repository
{
    public class SqlMovieRepository : IMovieRepository
    {
        private readonly MovieSearchContext context;

        public SqlMovieRepository(MovieSearchContext context)
        {
            this.context = context;                 
        }

        public async Task<List>CreateList(List list)
        {
           var newlist = await context.List.AddAsync(list);
            await context.SaveChangesAsync();
            return newlist.Entity;
        }

        public async Task<Movie> GetMovieAsync(Guid movieId)
        {
            return await context.Movie
                .Include(nameof(Genre))
                .Include(nameof(Language))
                .FirstOrDefaultAsync(x => x.Id == movieId);
        }
        
        public async Task<Movie> GetMovieByNameAsync(string movieName)
        {
            return await context.Movie
               .Include(nameof(Genre))
               .Include(nameof(Language))
               .FirstOrDefaultAsync(y => y.MovieName == movieName);
        }
        

        public async Task<List<Movie>> GetMoviesAsync()
        {
            return await context.Movie
             .Include(nameof(Genre))
             .Include(nameof(Language))
             .ToListAsync();
        }
    }
    
        
    
}
