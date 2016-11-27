using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YonazoneWorkForce.Models;

namespace YonazoneWorkForce.ViewModel
{
    public class CreateNewEmployeeViewModel : BaseViewModel
    {
        public Employee Employee { get; set; }

        public List<Employee> Employees { get; set; }

        public IEnumerable<SelectListItem> Department { get; set; }

        public List<SelectListItem> Departments { get; set; }

    }
}
