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
    public class ComputersController : Controller
    {
        private WorkforceContext context;

        public ComputersController(WorkforceContext ctx)
        {
            context = ctx;
        }
        public ActionResult Index()
        {
            var computerList = context.Computer.ToList();
            var EmployeeList = context.Employee.ToList();
            var model = new AllComputersViewModel();
            model.Computers = computerList;
            model.Employees = EmployeeList;

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new CreateNewComputerViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Computer Computer)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Computer.Add(Computer);
            try
            {
                context.SaveChanges();
                return RedirectToAction("Index", "Computers");
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
