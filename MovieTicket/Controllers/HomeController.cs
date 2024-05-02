using Microsoft.AspNetCore.Mvc;
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
            var randomMovies = _movieService.GetRandomMovies();
            return View(randomMovies);
        }
    }
}m