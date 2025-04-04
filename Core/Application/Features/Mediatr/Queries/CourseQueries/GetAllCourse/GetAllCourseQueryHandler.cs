using Application.Repositories.CourseRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Queries.CourseQueries.GetAllCourse
{
    public class GetAllCourseQueryHandler : IRequestHandler<GetAllCourseQeryRequest, List<GetAllCourseQeryResponse>>
    {
        private readonly ICourseReadRepository _readRepository;

        public GetAllCourseQueryHandler(ICourseReadRepository readRepository)
        {
            _readRepository = readRepository;
        }

        public async Task<List<GetAllCourseQeryResponse>> Handle(GetAllCourseQeryRequest request, CancellationToken cancellationToken)
        {
            var response  = _readRepository.GetAll(false).Select(s => new GetAllCourseQeryResponse
            {
                Id = s.Id,
                CourseCode = s.CourseCode,
                Title = s.Title,
                Classroom = s.Classroom.ClassroomName,
                CreatedTime = s.CreatedTime,
                UpdatedTime = s.UpdatedTime
            }).ToList();

            return response;

        }
    }


}
