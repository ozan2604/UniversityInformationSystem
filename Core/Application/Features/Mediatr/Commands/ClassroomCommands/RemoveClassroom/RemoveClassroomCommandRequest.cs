using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Commands.ClassroomCommands.RemoveClassroom
{
    public class RemoveClassroomCommandRequest : IRequest<RemoveClassroomCommandResponse>
    {
        public string Id { get; set; }
    }
}
