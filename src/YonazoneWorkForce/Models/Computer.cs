using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YonazoneWorkForce.Models
{
    public class Computer
    {
        [Key]
        public int ComputerId { get; set; }

        public string Model { get; set; }

        public double PurchasePrice { get; set; }

        public int EmployeeId { get; set; }
    }
}
