using Domain.Entities;
using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Queries.CourseQueries.GetAllCourse
{
    public class GetAllCourseQeryResponse : BaseEntity
    {
        public string CourseCode { get; set; }
        public string Title { get; set; }
        public string Classroom  { get; set; }
    }
}
