using Application.Repositories.CourseRepositories;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Queries.CourseQueries.GetByIdCourse
{
    public class GetByIdCourseQueryHandler : IRequestHandler<GetByIdCourseQueryRequest, GetByIdCourseQueryResponse>
    {
        private readonly ICourseReadRepository _readRepository;

        public GetByIdCourseQueryHandler(ICourseReadRepository readRepository)
        {
            _readRepository = readRepository;
        }

        public async Task<GetByIdCourseQueryResponse> Handle(GetByIdCourseQueryRequest request, CancellationToken cancellationToken)
        {
           Course course = await _readRepository.GetByIdAsync(request.Id, false);
            return new()
            {
                Id = course.Id,
                CourseCode = course.CourseCode,
                Title = course.Title,
                CreatedTime = course.CreatedTime,
                UpdatedTime = course.UpdatedTime,
                
            };  
        }
    }
}
