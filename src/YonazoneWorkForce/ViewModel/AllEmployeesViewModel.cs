using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YonazoneWorkForce.Models;
using YonazoneWorkForce.ViewModel;

namespace YonazoneWorkForce.ViewModels
{
    public class AllEmployeesViewModel : BaseViewModel
    {
        public List<Employee> Employees { get; internal set; }
    }
}
