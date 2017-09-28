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

            return View("CustomerForm",viewModel);

        }
        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if (customer.Id == 0)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                //Mapper.map(cusotmer, customerInDb)
                /*esta funcion es de la libreria mapper, para usarla de forma segura, esta accion deberia recibir como parametro un objeto 
                 * de clase diferente a Customer, por ejemplo una clase UpdateCustomer que tenga solo los campos del objeto autorizados a cambiar.
                 * Todo esto para evitar un ataque malicioso en donde se hagan requests con updates a campos que no hace falta modificar
                 */                
                customerInDb.Name = customer.Name;
                customerInDb.BirthDate= customer.BirthDate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSuscribedToNewsLetter= customer.IsSuscribedToNewsLetter;
                /* Lo que hago aca es seleccionar los campos que quiero modificar, ni mas ni menos
                 * Por ejemplo, si hiciese customerInDb = customer un atacante puede modificar el POST request para modificar campos que no se tienen 
                 * que modificar*/

            }    

            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
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
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();
            var viewModel = new NewCustomerViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };

            return View("CustomerForm",viewModel);
        }
    }
}