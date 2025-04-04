using Application.Features.Mediatr.Commands.StudentCommands.RemoveStudent;
using Domain.Entities.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Queries.StudentQueries.GetAllStudent
{
    public class GetAllStudentQueryRequest : IRequest<List<GetAllStudentQueryResponse>>
    {
        
    }
}
