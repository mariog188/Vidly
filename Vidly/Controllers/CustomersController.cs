using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext context;

        public CustomersController()
        {
            context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
            base.Dispose(disposing);    
        }

        public ViewResult Index()
        {
            var customers = context.Customers.Include(item => item.MembershipType).ToList();
            return View(customers);
        }

        [Route("Detail/{id}")]
        public ActionResult Detail(string id)
        {
            Customer customer = context.Customers.Include(item => item.MembershipType).ToList().FirstOrDefault(item => item.Id.ToString().Equals(id));
            if (customer != null)
                return View(customer);
            else
                return HttpNotFound();
        }
    }
}