using Domain.Entities.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Commands.StudentCommands.UpdateStudent
{
    public class UpdateStudentCommandRequest :  IRequest<UpdateStudentCommandResponse> 
    {
        public string Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public string IdentityNumber { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        

    }
    
}
