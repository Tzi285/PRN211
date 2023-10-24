using Lab2.Logics.IServices;
using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Logics.Services
{
    internal class CustomerService : ICustomerService
    {
        NorthwindContext _context = new NorthwindContext();
        public List<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }
    }

}
