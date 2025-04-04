using Application.Repositories.CourseRepositories;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Commands.CourseCommands.UpdateCourse
{
    public class UpdateCourseCommandHandler : IRequestHandler<UpdateCourseCommandRequest, UpdateCourseCommandResponse>
    {
        private readonly ICourseWriteRepository _courseWriteRepository;
        private readonly ICourseReadRepository _courseReadRepository;   

        public UpdateCourseCommandHandler(ICourseWriteRepository courseWriteRepository, ICourseReadRepository courseReadRepository)
        {
            _courseWriteRepository = courseWriteRepository;
            _courseReadRepository = courseReadRepository;
        }

        public async Task<UpdateCourseCommandResponse> Handle(UpdateCourseCommandRequest request, CancellationToken cancellationToken)
        {
            Course  course = await _courseReadRepository.GetByIdAsync(request.Id); 
            course.CourseCode = request.CourseCode;
            course.Title = request.Title;
            course.UpdatedTime = DateTime.Now;

            await _courseWriteRepository.SaveAsync();

            return new UpdateCourseCommandResponse
            {
                Message = "Course Updated Successfully"
            };  

        }
    }
}
