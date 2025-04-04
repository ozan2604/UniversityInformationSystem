using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Queries.CourseQueries.GetByIdCourse
{
    public class GetByIdCourseQueryResponse : BaseEntity
    {
        public string CourseCode { get; set; }
        public string Title { get; set; }
    }
}
