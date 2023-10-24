using DemoEF_BTVN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF_BTVN.Service
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
