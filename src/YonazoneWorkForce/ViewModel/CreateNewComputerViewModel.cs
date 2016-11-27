using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YonazoneWorkForce.Models;

namespace YonazoneWorkForce.ViewModel
{
    public class CreateNewComputerViewModel : BaseViewModel
    {
        public Computer Computer { get; set; }

        public Employee Employee { get; set; }

        public List<Employee> Employees { get; set; }

        public CreateNewComputerViewModel() { }

        public CreateNewComputerViewModel(Computer Computer) { }


    }
}
