using DemoEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.Logics
{
    internal class CategoryServices:BaseServices
    {
        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }
        public Category GetCategoryById(int cateId)
        {
            return _context.Categories.SingleOrDefault(c => c.CategoryId == cateId);
        }
    }
}
