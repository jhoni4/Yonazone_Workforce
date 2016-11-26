using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YonazoneWorkForce.Models;

namespace YonazoneWorkForce.Data
{
    public class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WorkforceContext(serviceProvider.GetRequiredService<DbContextOptions<WorkforceContext>>()))
            {
                //LOOK FOR ANY EMPLOYEE
                if (context.Employee.Any())
                {
                    return;
                }

                var employees = new Employee[]
                {
                    new Employee
                    {
                        FirstName = "George",
                        LastName = "Bush",
                        MiddleInitial = "W",
                        JobTitle = "President"
                    },
                    new Employee
                    {
                        FirstName = "Bini",
                        LastName = "Hammer",
                        MiddleInitial = "K",
                        JobTitle = "Cook"
                    },
                    new Employee
                    {
                        FirstName = "James",
                        LastName = "Bond",
                        MiddleInitial = "J",
                        JobTitle = "Security"
                    }
                };

                foreach (Employee e in employees)
                {
                    context.Employee.Add(e);
                }


                var computers = new Computer[]
                {
                    new Computer{
                        Model = "Lenovo",
                        PurchasePrice = 699.99
                    },
                    new Computer{
                        Model = "Asus",
                        PurchasePrice = 499.05
                    },
                    new Computer{
                        Model = "Mac",
                        PurchasePrice = 550.00
                    }
                };

                foreach (Computer c in computers)
                {
                    context.Computer.Add(c);
                }

                var departments = new Department[]
                {
                    new Department
                    {
                        Name = "IT",
                        Description = "A place to make your software dreams come true!"
                    },
                    new Department
                    {
                        Name = "Administration",
                        Description = "Bossing you around since buisness creation!"
                    },
                    new Department
                    {
                        Name = "Human Resources",
                        Description = "Developing relationships is our specialty!"
                    }
                };

                foreach (Department d in departments)
                {
                    context.Department.Add(d);
                }

                var trainingprograms = new TrainingProgram[]
                {
                    new TrainingProgram
                    {
                        Name = "C# For Dummies",
                        Description = "This program is for Dummies only!",
                        MaxCapacity = 500
                    },
                    new TrainingProgram
                    {
                        Name = "Cooking For Dummies",
                        Description = "Let's bake a cake!",
                        MaxCapacity = 50
                    },
                    new TrainingProgram
                    {
                        Name = "How to be Rich in Ten Days?",
                        Description = "Broke people only!",
                        MaxCapacity = 100
                    }
                };

                foreach (TrainingProgram tp in trainingprograms)
                {
                    context.TrainingProgram.Add(tp);
                }

                context.SaveChanges();

                var trainingemployees = new TrainingEmployee[]
                {
                    new TrainingEmployee
                    {
                        EmployeeId = 1,
                        TrainingProgramId = 1
                    },
                    new TrainingEmployee
                    {
                        EmployeeId = 2,
                        TrainingProgramId = 2
                    },
                    new TrainingEmployee
                    {
                        EmployeeId = 3,
                        TrainingProgramId = 3
                    }
                };

                foreach (TrainingEmployee te in trainingemployees)
                {
                    context.TrainingEmployee.Add(te);
                }

                context.SaveChanges();
            }
        }
    }
}
