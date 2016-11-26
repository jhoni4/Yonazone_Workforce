using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YonazoneWorkForce.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; } 

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string MiddleInitial { get; set; }

        [Required]
        public string JobTitle { get; set; }

        public int?  DepartmentId {get; set;}

        public Department Department { get; set; }

    }
}
