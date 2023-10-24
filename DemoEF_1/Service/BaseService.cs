using DemoEF_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF_1.Service
{
    internal class BaseService
    {
        protected NorthwindContext _context;

        public BaseService()
        {
            _context = new NorthwindContext();
        }
    }
}
