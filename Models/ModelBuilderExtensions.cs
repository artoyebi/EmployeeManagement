using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   Id = 5,
                   Name = "Mark",
                   Department = Dept.HR,
                   Email = "mark@code360.com"
               },
               new Employee
               {
                   Id = 6,
                   Name = "Job",
                   Department = Dept.Payroll,
                   Email = "job@code360.com"
               }
            );
        }
    }
}
