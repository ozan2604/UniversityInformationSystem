using Domain.Entities.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Commands.StudentCommands.CreateStudent
{
    public class CreateStudentCommandRequest : BaseEntity , IRequest<CreateStudentCommandResponse>
    {
        public string IdentityNumber { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public List<Guid> CourseIds { get; set; }
    }
}
