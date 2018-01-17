using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.Common;
namespace Contoso.Model
{
    public class Enrollments : AuditableEntity
    {
        public Course CourseId { get; set; }
        public Student StudentId { get; set; }
        public string Grade { get; set; }
    }
}
