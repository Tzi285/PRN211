using DemoEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.Logics
{
    internal class ProductServices:BaseServices
    {
        CategoryServices categoryService = new CategoryServices();
        public List<Product> GetProducts(int categoryId)
        {
            return _context.Products.Where(p => p.CategoryId == categoryId).ToList();
        }
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void RemoveProduct(int productId)
        {
            Product? p = _context.Products.FirstOrDefault(p => p.ProductId == productId);

            if (p != null)
            {
                _context.Products.Remove(p);
                _context.SaveChanges();
            }
        }
    }
}
