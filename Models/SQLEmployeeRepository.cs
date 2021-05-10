using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    
    public class SQLEmployeeRepository : IEmployeeRepository
    {


        private readonly ApplicationDbContext _context;
        private readonly ILogger<SQLEmployeeRepository> logger;

        public SQLEmployeeRepository(ApplicationDbContext context, ILogger<SQLEmployeeRepository> logger)
        {
            _context = context;
            this.logger = logger;
        }
        public Employee Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee Delete(int Id)
        {
            Employee employeeDelete = _context.Employees.Find(Id);
            if (employeeDelete != null)
            {
                _context.Employees.Remove(employeeDelete);
                _context.SaveChanges();
            }
            return employeeDelete;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {

            return _context.Employees.ToList();
        }

        public Employee GetEmployee(int Id)
        {
            logger.LogTrace("Trace Log");
            logger.LogDebug("Debug Log");
            logger.LogInformation("Info Log");
            logger.LogWarning("Warning Log");
            logger.LogError("Error Log");
            logger.LogCritical("Critical Log");
            return _context.Employees.Find(Id);
        }

        public Employee Update(Employee employeeChanges)
        {
            var employeeUpdate = _context.Employees.Attach(employeeChanges);
            employeeUpdate.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return employeeChanges;
        }
    }
}
