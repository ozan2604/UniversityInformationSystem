using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Queries.CourseQueries.GetAllCourse
{
    public class GetAllCourseQeryRequest : IRequest<List<GetAllCourseQeryResponse>>   
    {
    }
}
