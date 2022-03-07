using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_ENTITY_CORE.Models;
namespace MVC_ENTITY_CORE.Controllers
{
    public class CustomerController:Controller
    {
        private ApplicationDbContext DbContext;
        public CustomerController(ApplicationDbContext dbContext)
        {
            this.DbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Location> locations = DbContext.locations.ToList();
            return View(locations);

        }
        public IActionResult CustomerList(int id)
        {
            List<Customer> customers = DbContext.customers.Where(e =>
               e.location.ID == id).ToList();
            return View(customers);

        }
       


    }
}
