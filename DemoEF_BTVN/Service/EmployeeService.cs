using DemoEF_BTVN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF_BTVN.Service
{
    internal class EmployeeService : BaseService
    {
        // Phương thức lấy tất cả Employees
        public List<Employee> GetAllEmployees()
        {
                return _context.Employees.ToList();
        }
    }
}
