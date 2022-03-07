using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_ENTITY_CORE.Models;
using Microsoft.EntityFrameworkCore;
namespace MVC_ENTITY_CORE.Controllers
{
    public class CompanyController: Controller
    {
        private ApplicationDbContext DbContext;
        public CompanyController(ApplicationDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

           public IActionResult Index()
           {
            List<Company> companies = DbContext.companies.ToList();
            return View(companies);

           }
        [HttpPost]
        public IActionResult CREATE(Company cmp)
        {
            DbContext.companies.Add(cmp);
            DbContext.SaveChanges();
            return RedirectToAction("Index");
        }
       
    }
}
