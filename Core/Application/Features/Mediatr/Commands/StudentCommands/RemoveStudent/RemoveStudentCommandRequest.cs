using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Commands.StudentCommands.RemoveStudent
{
    public class RemoveStudentCommandRequest : IRequest<RemoveStudentCommandResponse>   
    {
        public string Id { get; set; }  
    }
}
