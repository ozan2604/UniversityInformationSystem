using Domain.Entities.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Commands.ClassroomCommands.CreateClassroom
{
    public class CreateClassroomCommandRequest : BaseEntity , IRequest<CreateClassroomCommandResponse>
    {
        public string ClassroomName { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
    }
}
