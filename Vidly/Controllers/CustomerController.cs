using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customer
        //[Route("Customers/Index") ]
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                 new Customer { Id =0, Name = "Ernersto Guevara" }
                ,new Customer { Id=1, Name = "Pablo Gomez"}
            };
            var viewModel = new CustomerIndexViewModel
            {
                Customers = customers
            };
            return View(viewModel);
        }
        public ActionResult Details(Customer customer)
        {
            return View(customer);
        }
    }
}