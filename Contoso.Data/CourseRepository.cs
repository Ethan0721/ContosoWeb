using Contoso.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;

namespace Contoso.Data
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {

        public CourseRepository(ContosoDbContext context) : base(context)
        {

        }

        public Course GetCourseByTitle(string title)
        {
            var course = _context.Courses.OfType<Course>().FirstOrDefault(s => s.Title == title);
            return course;
        }
    }

    public interface ICourseRepository : IRepository<Course> {
        Course GetCourseByTitle(string title);
    }
}
