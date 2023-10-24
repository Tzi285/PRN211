using Lab2.Logics.IServices;
using Lab2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Logics.Services
{
    internal class OrderService : IOrderService
    {
        NorthwindContext _context;

        public OrderService()
        {
            _context = new NorthwindContext();
        }

        public List<Order> GetOrders(int EmployeeId, string CustomerId, DateTime? FromDate, DateTime? ToDate, string? OrderByProperty)
        {
            List<Order> orders = _context.Orders
                .Where(p => (EmployeeId == 0 || p.EmployeeId == EmployeeId)
                    && (CustomerId.Equals(string.Empty) ||
                        (p.CustomerId != null && p.CustomerId.Equals(CustomerId)))
                    && (p.OrderDate >= FromDate && p.OrderDate <= ToDate)
                )
                .Include(o => o.Employee)
                .Include(o => o.Customer)
                .ToList();

            switch (OrderByProperty)
            {
                case "OrderId": orders.OrderBy(o => o.OrderId).ToList(); break;
                case "Customer": orders.OrderBy(o => o.CustomerId).ToList(); break;
                case "Employee": orders.OrderBy(o => o.EmployeeId).ToList(); break;
                case "OrderDate": orders.OrderBy(o => o.OrderDate).ToList(); break;
                case "Freight": orders.OrderBy(o => o.Freight).ToList(); break;
            }
            return orders;
        }

    }
}
