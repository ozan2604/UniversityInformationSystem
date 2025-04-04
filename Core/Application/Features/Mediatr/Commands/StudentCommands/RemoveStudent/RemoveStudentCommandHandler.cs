using Application.Repositories.StudentRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Commands.StudentCommands.RemoveStudent
{
    public class RemoveStudentCommandHandler : IRequestHandler<RemoveStudentCommandRequest, RemoveStudentCommandResponse>
    {
        public readonly IStudentWriteRepository _repository;

        public RemoveStudentCommandHandler(IStudentWriteRepository repository)
        {
            _repository = repository;
        }
        public async Task<RemoveStudentCommandResponse> Handle(RemoveStudentCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.RemoveAsync(request.Id);
            await _repository.SaveAsync();

            return new RemoveStudentCommandResponse()
            {
                Message = "Student Removed Successfully"
            };
        }
    }
}
