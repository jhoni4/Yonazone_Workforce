using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YonazoneWorkForce.Models;

namespace YonazoneWorkForce.Data
{
    public class WorkforceContext : DbContext
    {

        public WorkforceContext(DbContextOptions<WorkforceContext> options) : base(options) { }

        public DbSet<Computer> Computer { get; set; }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<TrainingEmployee> TrainingEmployee { get; set; }

        public DbSet<Department> Department { get; set; }

        public DbSet<TrainingProgram> TrainingProgram { get; set; }
    }

}
