using DemoEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.Logics
{
    internal class BaseServices
    {
        protected NorthwindContext _context;
        public BaseServices() 
        {
            _context = new NorthwindContext();  
        }   
    }
}
