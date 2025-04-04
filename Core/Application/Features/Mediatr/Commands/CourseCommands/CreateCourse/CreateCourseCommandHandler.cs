using Application.Repositories.CourseRepositories;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Commands.CourseCommands.CreateCourse
{
    public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommandRequest, CreateCourseCommandResponse>
    {
        private readonly ICourseWriteRepository _writeRepository;

        public CreateCourseCommandHandler(ICourseWriteRepository writeRepository)
        {
            _writeRepository = writeRepository;
        }

        public async Task<CreateCourseCommandResponse> Handle(CreateCourseCommandRequest request, CancellationToken cancellationToken)
        {
            await _writeRepository.AddAsync(new Course
            {
                CourseCode = request.CourseCode,
                Title = request.Title,
                ClassroomId = request.ClassroomId,
                CreatedTime = DateTime.Now,
                UpdatedTime = DateTime.Now
            });

            await _writeRepository.SaveAsync();

            return new CreateCourseCommandResponse
            {
                Message = "Course Created Successfully"
            };
        }
    }   
    
}
