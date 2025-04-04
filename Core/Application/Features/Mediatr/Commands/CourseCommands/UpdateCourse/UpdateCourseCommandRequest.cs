using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Commands.CourseCommands.UpdateCourse
{
    public class UpdateCourseCommandRequest : IRequest<UpdateCourseCommandResponse> 
    {
        public string Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public string CourseCode { get; set; }
        public string Title { get; set; }
    }
}
