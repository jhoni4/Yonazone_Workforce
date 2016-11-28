using System.Collections.Generic;
using YonazoneWorkForce.ViewModels;
using YonazoneWorkForce.Models;

namespace YonazoneWorkForce.ViewModels
{
    public class AllEmployeesViewModel : BaseViewModel
    {
        public List<Employee> Employees { get; internal set; }
    }
}
