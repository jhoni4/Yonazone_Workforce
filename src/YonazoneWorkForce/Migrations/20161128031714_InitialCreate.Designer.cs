using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using YonazoneWorkForce.Data;

namespace YonazoneWorkForce.Migrations
{
    [DbContext(typeof(WorkforceContext))]
    [Migration("20161128031714_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1");

            modelBuilder.Entity("YonazoneWorkForce.Models.Computer", b =>
                {
                    b.Property<int>("ComputerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EmployeeId");

                    b.Property<string>("Model")
                        .IsRequired();

                    b.Property<double>("PurchasePrice");

                    b.HasKey("ComputerId");

                    b.ToTable("Computer");
                });

            modelBuilder.Entity("YonazoneWorkForce.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("DepartmentId");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("YonazoneWorkForce.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("JobTitle")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("MiddleInitial")
                        .IsRequired();

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("YonazoneWorkForce.Models.TrainingEmployee", b =>
                {
                    b.Property<int>("TrainingEmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EmployeeId");

                    b.Property<int>("TrainingProgramId");

                    b.HasKey("TrainingEmployeeId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TrainingProgramId");

                    b.ToTable("TrainingEmployee");
                });

            modelBuilder.Entity("YonazoneWorkForce.Models.TrainingProgram", b =>
                {
                    b.Property<int>("TrainingProgramId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("MaxCapacity");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("TrainingProgramId");

                    b.ToTable("TrainingProgram");
                });

            modelBuilder.Entity("YonazoneWorkForce.Models.Employee", b =>
                {
                    b.HasOne("YonazoneWorkForce.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");
                });

            modelBuilder.Entity("YonazoneWorkForce.Models.TrainingEmployee", b =>
                {
                    b.HasOne("YonazoneWorkForce.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("YonazoneWorkForce.Models.TrainingProgram", "TrainingProgram")
                        .WithMany()
                        .HasForeignKey("TrainingProgramId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
