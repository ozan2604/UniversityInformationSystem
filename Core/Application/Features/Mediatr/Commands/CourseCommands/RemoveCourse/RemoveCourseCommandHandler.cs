
using Application.Repositories.CourseRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Commands.CourseCommands.RemoveCourse
{
    public class RemoveCourseCommandHandler : IRequestHandler<RemoveCourseCommandRequest, RemoveCourseCommandResponse>
    {

        private readonly ICourseWriteRepository _writeRepository;

        public RemoveCourseCommandHandler(ICourseWriteRepository writeRepository)
        {
            _writeRepository = writeRepository;
        }

        public async Task<RemoveCourseCommandResponse> Handle(RemoveCourseCommandRequest request, CancellationToken cancellationToken)
        {
            await _writeRepository.RemoveAsync(request.Id);
            await _writeRepository.SaveAsync();

            return new RemoveCourseCommandResponse()
            {
                Message = "Course Removed Successfully"
            };

        }
    }
}
