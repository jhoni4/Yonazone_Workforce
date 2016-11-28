using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YonazoneWorkForce.Models;
using YonazoneWorkForce.ViewModels;

namespace YonazoneWorkForce.ViewModels
{
    public class CreateNewEmployeeViewModel : BaseViewModel
    {
        public Employee Employee { get; set; }

        public List<Employee> Employees { get; set; }
        public CreateNewEmployeeViewModel() { }
        public CreateNewEmployeeViewModel(Employee Employee) { }

    }
}
