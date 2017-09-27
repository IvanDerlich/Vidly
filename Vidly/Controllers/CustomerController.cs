using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {

        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes;

            var viewModel = new NewCustomerViewModel();

            viewModel.MembershipTypes = membershipTypes;

            return View(viewModel);

        }
        // GET: Customer
        //[Route("Customers/Index") ]
        public ActionResult Index()
        {

            var customers = _context.Customers.Include(mem => mem.MembershipType).ToList();

            return View(customers);

        }
        public ActionResult Details(int id)
        {

            var customer = _context.Customers.Include(mem => mem.MembershipType).SingleOrDefault(c => c.Id == id);            
            
            if (customer == null) 
                return HttpNotFound();

            return View(customer);
        }            
    }
}