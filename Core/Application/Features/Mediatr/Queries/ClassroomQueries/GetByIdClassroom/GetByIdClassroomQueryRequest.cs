using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Queries.ClassroomQueries.GetByIdClassroom
{
    public class GetByIdClassroomQueryRequest : IRequest<GetByIdClassroomQueryResponse>
    {
        public string Id { get; set; }
    }
}
