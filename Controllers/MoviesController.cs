using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieSearchAPI.DomainModels;
using MovieSearchAPI.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieSearchAPI.Controllers
{
    [ApiController]
    public class MoviesController : Controller
    {
       
        private readonly IMovieRepository movieRepository;
        private readonly IMapper mapper;

        public MoviesController(IMovieRepository movieRepository, IMapper mapper)
        {
            this.movieRepository = movieRepository;
            this.mapper = mapper;
                 
        }
        [HttpGet]
        [Route("[Controller]")]
        public async Task<IActionResult> GetAllMovies()
        {
           
           var movies = await movieRepository.GetMoviesAsync();
            return Ok(mapper.Map<List<Movie>>(movies));
            /*
            var domainModelMovies = new List<Movie>();

            foreach(var movie in movies)
            {
                domainModelMovies.Add(new Movie()
                {
                    Id = movie.Id,
                    MovieName = movie.MovieName,
                    ReleaseDate = movie.ReleaseDate,
                    ImdbRating = movie.ImdbRating,
                    MovieCast = movie.MovieCast,
                    GenreId = movie.GenreId,
                    LanguageId = movie.LanguageId,
                    Genre = new Genre()
                    {
                        Id = movie.Genre.Id,
                        Category = movie.Genre.Category,
                    },
                    Language = new Language()
                    {
                        Id = movie.Language.Id,
                        MovieLanguage = movie.Language.MovieLanguage,
                    }
                });
            }*/
           // return Ok(domainModelMovies);
        }

        [HttpGet]
        [Route("[controller]/{movieId:guid}")]
        public async Task<IActionResult> GetMovieAysnc([FromRoute] Guid movieId)
        {

            var movie = await movieRepository.GetMovieAsync(movieId);

            if(movie == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<Movie>(movie));



        }
        
        [HttpGet]
        [Route("[controller]/{movieName:alpha}")]

        public async Task<IActionResult>GetMovieByNameAsync([FromRoute] string movieName)
        {
            var moviename = await movieRepository.GetMovieByNameAsync(movieName);
            if(moviename == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<Movie>(moviename));
        }
        
    }
}
