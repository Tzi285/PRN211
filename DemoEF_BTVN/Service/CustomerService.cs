using DemoEF_BTVN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF_BTVN.Service
{
    internal class CustomerService : BaseService
    {
        // Phương thức lấy tất cả Customers
        public List<Customer> GetAllCustomers()
        {
                return _context.Customers.ToList();
        }
    }
}
