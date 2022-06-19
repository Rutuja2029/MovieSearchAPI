
using MovieSearchAPI.DataModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieSearchAPI.Repository
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetMoviesAsync();

        Task<Movie> GetMovieAsync(Guid movieId);

        Task<Movie> GetMovieByNameAsync(string movieName);

        Task<List>CreateList(List list);

    }
}
