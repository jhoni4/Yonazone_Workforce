using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YonazoneWorkForce.Models;

namespace YonazoneWorkForce.ViewModel
{
    public class AllComputersViewModel : BaseViewModel
    {
        public List<Computer> Computers { get; set; }

        public Computer Computer { get; set; }

        public List<Employee> Employees { get; set; }

        public AllComputersViewModel() { }
    }
}
