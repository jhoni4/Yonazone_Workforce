using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YonazoneWorkForce.Data;
using YonazoneWorkForce.ViewModels;
using YonazoneWorkForce.Models;

namespace YonazoneWorkForce.Controllers
{
    public class EmployeesController : Controller
    {
        private WorkforceContext context;

        public EmployeesController(WorkforceContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            ViewData["Title"] = "Employee Page";
            AllEmployeesViewModel model = new AllEmployeesViewModel();
            model.Employees = context.Employee.ToList();
            return View(model);
        }

        public IActionResult Detail()
        {
            ViewData["Message"] = "Your Employee description page.";

            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            CreateNewEmployeeViewModel model = new CreateNewEmployeeViewModel();

            return View(model);
        }
        [HttpPost]
        public IActionResult Create(Employee Employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Add(Employee);
            try
            {
                context.SaveChanges();
                return RedirectToAction("Index", Employee);
            }
            catch
            {
                throw;
            }
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
