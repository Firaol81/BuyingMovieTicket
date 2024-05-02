// MovieService.cs
using MovieTicket.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieTicket.Services
{
    public class MovieService
    {
        private readonly List<Movie> _movies;

        public MovieService()
        {
            // Initialize with some sample movies
            _movies = new List<Movie>
            {
                new Movie { Id = 1, Title = "Sample Movie 1", Description = "Description for Sample Movie 1", Showtimes = new List<DateTime> { DateTime.Today.AddHours(18), DateTime.Today.AddHours(20) } },
                new Movie { Id = 2, Title = "Sample Movie 2", Description = "Description for Sample Movie 2", Showtimes = new List<DateTime> { DateTime.Today.AddHours(17), DateTime.Today.AddHours(19) } }
            };
        }

        public List<Movie> GetMovies()
        {
            // Return the list of movies
            return _movies.ToList();
        }

        public Movie GetMovieById(int id)
        {
            // Find and return the movie with the specified ID
            return _movies.FirstOrDefault(m => m.Id == id);
        }

        public List<Movie> GetRandomMovies()
        {
            // Return a random list of movies (for demonstration purposes)
            Random rnd = new Random();
            var randomMovies = _movies.OrderBy(m => rnd.Next()).ToList();
            return randomMovies;
        }
    }
}

