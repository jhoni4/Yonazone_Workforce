using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YonazoneWorkForce.Models;
using YonazoneWorkForce.ViewModels;

namespace YonazoneWorkForce.ViewModels
{
    public class CreateNewDepartmentViewModel : BaseViewModel
    {
        public Department Department { get; set; }
        public CreateNewDepartmentViewModel() { }
        public CreateNewDepartmentViewModel(Department Department) { }
    }
}

