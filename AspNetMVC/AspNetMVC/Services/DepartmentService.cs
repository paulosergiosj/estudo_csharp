using AspNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMVC.Services
{
    public class DepartmentService
    {
        private readonly AspNetMVCContext _context;

        public DepartmentService(AspNetMVCContext context)
        {
            _context = context;
        }
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
