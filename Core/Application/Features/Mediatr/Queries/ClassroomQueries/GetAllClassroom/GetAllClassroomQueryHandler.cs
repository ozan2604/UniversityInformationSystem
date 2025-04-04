using Application.Features.Mediatr.Queries.ClassroomQueries.GetAllClassroom;
using Application.Repositories.ClassroomRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Queries.ClassroomQueries.GetAllClassroom
{
    public class GetAllClassroomQueryHandler : IRequestHandler<GetAllClassroomQueryRequest, List<GetAllClassroomQueryResponse>>
    {
        private readonly IClassroomReadRepository _readRepository;

        public GetAllClassroomQueryHandler(IClassroomReadRepository readRepository)
        {
            _readRepository = readRepository;
        }

        public async Task<List<GetAllClassroomQueryResponse>> Handle(GetAllClassroomQueryRequest request, CancellationToken cancellationToken)
        {
            var response = _readRepository.GetAll(false).Select(s => new GetAllClassroomQueryResponse
            {
                Id = s.Id,
                ClassroomName = s.ClassroomName,
                Description = s.Description,
                Capacity = s.Capacity,
                CreatedTime = s.CreatedTime,
                UpdatedTime = s.UpdatedTime
            }).ToList();

            return response;

        }
    }
}
