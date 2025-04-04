using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Commands.ClassroomCommands.UpdateClassroom
{
    public class UpdateClassroomCommandRequest : IRequest<UpdateClassroomCommandResponse>   
    {
        public string Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public string ClassroomName { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
    }
}
