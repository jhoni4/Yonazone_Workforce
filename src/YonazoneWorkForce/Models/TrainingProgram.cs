using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YonazoneWorkForce.Models
{
    public class TrainingProgram
    {
        [Key]
        public int TrainingProgramId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int MaxCapacity { get; set; }
    }
}

