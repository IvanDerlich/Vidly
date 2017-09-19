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
        // GET: Movies
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                 new Movie() { Id = 0, Name = "La pistola desnuda" }
                ,new Movie() {Id = 1, Name = "Batman" }
            };
            var viewModel = new MovieIndexViewModel
            {
                Movies = movies
            };
            return View(viewModel);
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
    }
}