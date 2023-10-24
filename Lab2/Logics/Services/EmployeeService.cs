using Lab2.Logics.IServices;
using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Logics.Services
{
    internal class EmployeeService : IEmployeeService
    {
        NorthwindContext _context = new NorthwindContext();
        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

    }
}
