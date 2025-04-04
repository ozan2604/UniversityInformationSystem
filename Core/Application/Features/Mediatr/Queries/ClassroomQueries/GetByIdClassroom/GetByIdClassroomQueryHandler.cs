using Application.Features.Mediatr.Queries.ClassroomQueries.GetByIdClassroom;
using Application.Repositories.ClassroomRepositories;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Queries.ClassroomQueries.GetByIdClassroom
{
    public class GetByIdClassroomQueryHandler : IRequestHandler<GetByIdClassroomQueryRequest, GetByIdClassroomQueryResponse>
    {
        private readonly IClassroomReadRepository _readRepository;

        public GetByIdClassroomQueryHandler(IClassroomReadRepository readRepository)
        {
            _readRepository = readRepository;
        }

        public async Task<GetByIdClassroomQueryResponse> Handle(GetByIdClassroomQueryRequest request, CancellationToken cancellationToken)
        {
            Classroom course = await _readRepository.GetByIdAsync(request.Id, false);
            return new()
            {
                Id = course.Id,
                ClassroomName = course.ClassroomName,
                Description = course.Description,
                CreatedTime = course.CreatedTime,
                UpdatedTime = course.UpdatedTime,
                Capacity = course.Capacity

            };
        }
    }
}
