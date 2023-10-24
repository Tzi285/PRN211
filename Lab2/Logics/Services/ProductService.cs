using Lab2.Logics.IServices;
using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Logics.Services
{
    internal class ProductService : IProductService
    {
        NorthwindContext _context = new NorthwindContext();
        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }
        public Product GetProductByName(string productName)
        {
            // Sử dụng LINQ để tìm sản phẩm dựa trên tên
            return _context.Products.FirstOrDefault(product => product.ProductName == productName);
        }
    }
}
