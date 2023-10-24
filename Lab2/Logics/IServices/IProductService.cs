using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Logics.IServices
{
    public interface IProductService
    {
        public List<Product> GetProducts();
        public Product GetProductByName(string productName);
    }
}
