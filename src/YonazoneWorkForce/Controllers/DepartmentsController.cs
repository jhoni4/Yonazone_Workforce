using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YonazoneWorkForce.ViewModels;
using YonazoneWorkForce.Data;
using Microsoft.EntityFrameworkCore;
using YonazoneWorkForce.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace YonazoneWorkForce.Controllers
{
    public class DepartmentsController : Controller
    {
        private WorkforceContext context;

        public DepartmentsController(WorkforceContext ctx)
        {
            context = ctx;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var model = new AllDepartmentsViewModel();
            model.Departments = await context.Department.ToListAsync();
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            CreateNewDepartmentViewModel model = new CreateNewDepartmentViewModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(Department Department)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Add(Department);
            try
            {
                context.SaveChanges();
                return RedirectToAction("Index", Department);
            }
            catch
            {
                throw;
            }
        }

        public IActionResult Detail()
        {
            ViewData["Message"] = "Your Department Detail page.";
            return View();
        }
    }
}
