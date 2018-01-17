using Contoso.Data;
using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service
{
    public class DepartmentServices : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentServices(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _departmentRepository.GetAll();
        }

        public IEnumerable<Department> GetAllDepartmentsWithCourses()
        {
            return _departmentRepository.GetCourse();
        }

        public List<Department> GetCourse()
        {
            return _departmentRepository.GetCourse();
        }
    }
    public interface IDepartmentService {
        IEnumerable<Department> GetAllDepartments();
        //Department GetDepartmentByName(string name);
        IEnumerable<Department> GetAllDepartmentsWithCourses();
        List<Department> GetCourse();
    }
}
