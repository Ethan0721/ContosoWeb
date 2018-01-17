using Contoso.Data;
using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service
{
    public class StudentServices : IStudentService
    {
        private readonly IStudnetRepository _studentRepository;
        public StudentServices(IStudnetRepository studentRepository) {
            _studentRepository = studentRepository;
        }

        public IEnumerable<Student> GetStudents()
        {
            return _studentRepository.GetAll();
        }

        public Student GetStudentByLastName(string lastname)
        {
            return _studentRepository.GetStudentByLastName(lastname);
        }  
    }

    public interface IStudentService {
        IEnumerable<Student> GetStudents();
        Student GetStudentByLastName(string lastName);
    }
}
