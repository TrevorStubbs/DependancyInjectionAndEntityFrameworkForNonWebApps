using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using EFInAWinFormsApp.Model.Entities;

namespace EFInAWinFormsApp.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "Trevor",
                    LastName = "Stubbs",
                    Address = "12345 67th ave sw",
                    ZipCode = 12345,
                    State = "Wa",
                    Country = "USA"
                });
        }


        public DbSet<Employee> Employees { get; set; }
    }
}
