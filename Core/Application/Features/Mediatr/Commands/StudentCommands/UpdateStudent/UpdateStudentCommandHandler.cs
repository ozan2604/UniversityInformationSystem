using Application.Repositories.CourseRepositories;
using Application.Repositories.StudentRepositories;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Commands.StudentCommands.UpdateStudent
{
    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommandRequest, UpdateStudentCommandResponse>
    {
        private readonly IStudentReadRepository _readRepository;
        private readonly IStudentWriteRepository _writeRepository;
       

        public UpdateStudentCommandHandler(
            IStudentReadRepository readRepository,
            IStudentWriteRepository writeRepository,
            ICourseReadRepository courseReadRepository)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
        }

        public async Task<UpdateStudentCommandResponse> Handle(UpdateStudentCommandRequest request, CancellationToken cancellationToken)
        {
          
            Student student = await _readRepository.GetByIdAsync(request.Id);

            student.IdentityNumber = request.IdentityNumber;
            student.FullName = request.FullName;
            student.Email = request.Email;
            student.UpdatedTime = DateTime.UtcNow;


            await _writeRepository.SaveAsync();

            return new UpdateStudentCommandResponse
            {
                Message = "Student Updated Successfully"
            };
        }
    }
}

