using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;
namespace Contoso.Data
{
    public class StudentRepository : Repository<Student>, IStudnetRepository
    {
        public StudentRepository(ContosoDbContext context) : base(context) {
        }

        public Student GetStudentByLastName(string lastname)
        {
            var student = _context.People.OfType<Student>().FirstOrDefault(s=>s.LastName == lastname);
            return student;
        }
    }
    public interface IStudnetRepository : IRepository<Student>
    {
        Student GetStudentByLastName(string lastname);
    }
}
