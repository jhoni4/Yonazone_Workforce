using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YonazoneWorkForce.Data;
using YonazoneWorkForce.ViewModel;

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

        public IActionResult Create()
        {
            ViewData["Message"] = "Ypur Taining Programe Create Page.";
            return View();
        }

        public IActionResult Detail()
        {
            ViewData["Message"] = "Ypur Taining Programe Detail Page.";
            return View();
        }
    }
}
