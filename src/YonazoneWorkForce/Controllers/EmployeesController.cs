using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YonazoneWorkForce.Data;
using YonazoneWorkForce.Models;
using YonazoneWorkForce.ViewModels;

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

        public IActionResult Create()
        {
            ViewData["Message"] = "Your Employee Create page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
