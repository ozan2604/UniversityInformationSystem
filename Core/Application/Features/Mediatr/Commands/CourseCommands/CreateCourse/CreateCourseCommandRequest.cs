using Domain.Entities.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Commands.CourseCommands.CreateCourse
{
    public class CreateCourseCommandRequest : BaseEntity, IRequest<CreateCourseCommandResponse> 
    {
        public string CourseCode { get; set; }
        public string Title { get; set; }
        public Guid ClassroomId { get; set; }
    }
}
