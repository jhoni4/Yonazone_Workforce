using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YonazoneWorkForce.Data;
using YonazoneWorkForce.ViewModels;
using Microsoft.EntityFrameworkCore;
using YonazoneWorkForce.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace YonazoneWorkForce.Controllers
{
    public class TrainingProgramsController : Controller
    {
        private WorkforceContext context;

        public TrainingProgramsController(WorkforceContext ctx)
        {
            context = ctx;
        }
            // GET: /<controller>/
        public IActionResult Index()
        {
            ////ViewData["Title"] = "All Trainig Program";
            var tpList = context.TrainingProgram.ToList();
            var model = new AllTrainingProgrameViewModel();
            model.TrainingPrograms = tpList;
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new CreateNewTrainingProgramViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Employee TrainingProgram)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Add(TrainingProgram);
            try
            {
                context.SaveChanges();
                return RedirectToAction("Index", TrainingProgram);
            }
            catch
            {
                throw;
            }
        }

        public IActionResult Detail()
        {
            ViewData["Message"] = "Ypur Taining Programe Detail Page.";
            return View();
        }
    }
}
