using Microsoft.AspNetCore.Mvc;
using MovieTicket.Models;
using MovieTicket.Services;

namespace MovieTicket.Controllers
{
    public class HomeController : Controller
    {
        private readonly MovieService _movieService;

        public HomeController(MovieService movieService)
        {
            _movieService = movieService;
        }


        public IActionResult Index()
        {
            var movies = _movieService.GetMovies();
            return View(movies);
        }

    }
}
