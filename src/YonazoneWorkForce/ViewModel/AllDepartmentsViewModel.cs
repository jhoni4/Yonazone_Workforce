using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YonazoneWorkForce.Models;

namespace YonazoneWorkForce.ViewModel
{
    public class AllDepartmentsViewModel : BaseViewModel
    {
        public List<Department> Departments { get; set; }

        public Department Department { get; set; }

        public List<Employee> Employees { get; set; }

        public Employee Employee { get; set; }

        public AllDepartmentsViewModel () {}
    }
}
