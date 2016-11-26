using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YonazoneWorkForce.Models
{
    public class TrainingEmployee
    {
        [Key]
        public int TrainingEmployeeId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        [Required]
        public int TrainingProgramId { get; set; }

        public TrainingProgram TrainingProgram { get; set; }

    }
}
