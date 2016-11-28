using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YonazoneWorkForce.Models;
using YonazoneWorkForce.ViewModels;

namespace YonazoneWorkForce.ViewModels
{
    public class AllDepartmentsViewModel : BaseViewModel
    {
        public List<Department> Departments { get; set; }

        public Department Department { get; set; }

        public List<Employee> Employees { get; set; }

        public Employee Employee { get; set; }

    }
}
