using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies
        public ActionResult Index()
        {
            //var movie = _context.Movies.;
            var movie = GetMovie();
            return View(movie);
        }
        public ActionResult Details(int id)
        {
            var movie = GetMovie().SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "La pistola desnuda" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Pepe Pistola" },
                new Customer { Name = "Nancy Sinaola" }
            };
            var viewModel = new RandomViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }
        private IEnumerable<Movie> GetMovie()
        {
            return new List<Movie> {
                new Movie  { Name = "Sick City" },
                new Movie { Name = "The Matrix" }
            };
        }



    }
}