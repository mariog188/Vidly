using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        private IEnumerable<Movie> GetMovies()
         {
             return new List<Movie>
             {
                 new Movie { Id = 1, Name = "Shrek" },
                 new Movie { Id = 2, Name = "Wall-e" }
             };
         }

        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        // GET: Movie
        public ActionResult Random()
        {
            Movie movie = new Movie() { Name = "Shrek" };
            List<Customer> customers = new List<Customer>
            {
                new Customer { Name = "Mario" },
                new Customer { Name = "Alejandro"}
            };
            RandomMovieVM randomVM = new RandomMovieVM
            {
                Movie = movie,
                Customers = customers
            };
            return View(randomVM);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "Name" });
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{year}{"/"}{month}");
        }

        public ActionResult Edit(int id)
        {
            return Content($"{"id="}{id}");
        }
    }
}
