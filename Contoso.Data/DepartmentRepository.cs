using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(ContosoDbContext context) : base(context)
        {
       
        }
        public Department getDepartmentByName(string  name)
        {
            var department = _context.Departments.OfType<Department>().FirstOrDefault(s => s.Name == name);
            return department;
        }

        public List<Department> GetCourse( )
        {
            return _context.Departments.Include("Course").ToList();   
        }
    }
    public interface IDepartmentRepository : IRepository<Department>
    {
        Department getDepartmentByName(string name );
        List<Department> GetCourse();
    }
}
