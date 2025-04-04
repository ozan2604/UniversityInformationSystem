using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Course : BaseEntity
    {
        public string CourseCode { get; set; }
        public string Title { get; set; }
        public List<Student> Student { get; set; }
        public Guid ClassroomId { get; set; }
        public Classroom Classroom { get; set; }
    }
}
