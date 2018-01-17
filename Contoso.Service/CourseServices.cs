using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Model;

namespace Contoso.Service
{
    public class CourseServices : ICourseServices
    {
        private readonly ICourseRepository _courseRepository;

        public CourseServices(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public IEnumerable<Course> GetCourse()
        {
            return _courseRepository.GetAll();
        }

        public Course GetCourseByTitle(string title)
        {
            return _courseRepository.GetCourseByTitle(title);
        }
    }

    public interface ICourseServices {
        IEnumerable<Course> GetCourse();
        Course GetCourseByTitle(string lastName);
    }
}

