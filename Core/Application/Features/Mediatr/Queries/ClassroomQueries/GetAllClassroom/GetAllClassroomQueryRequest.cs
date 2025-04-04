using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Queries.ClassroomQueries.GetAllClassroom
{
    public class GetAllClassroomQueryRequest : IRequest<List<GetAllClassroomQueryResponse>>
    {
    }
}
