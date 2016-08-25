using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {

        // GET: Customers        
        public IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>{
                new Customer {Id = 1, Name = "Mario Gutierrez" },
                new Customer {Id = 2, Name = "Alejandro Isaza" }
            };
        }

        public ViewResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        [Route("Detail/{id}")]
        public ActionResult Detail(string id)
        {
            var customers = GetCustomers();
            Customer customer = customers.FirstOrDefault(item => item.Id.ToString().Equals(id));
            if (customer != null)
                return View(customer);
            else
                return HttpNotFound();
        }
    }
}