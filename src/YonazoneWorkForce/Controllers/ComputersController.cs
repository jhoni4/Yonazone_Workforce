using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YonazoneWorkForce.Data;
using YonazoneWorkForce.ViewModel;

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

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
