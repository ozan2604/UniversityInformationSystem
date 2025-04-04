using Application.Features.Mediatr.Commands.ClassroomCommands.RemoveClassroom;
using Application.Repositories.ClassroomRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Commands.ClassroomCommands.RemoveClassroom
{
    public class RemoveClassroomCommandHandler : IRequestHandler<RemoveClassroomCommandRequest, RemoveClassroomCommandResponse>
    {

        private readonly IClassroomWriteRepository _writeRepository;

        public RemoveClassroomCommandHandler(IClassroomWriteRepository writeRepository)
        {
            _writeRepository = writeRepository;
        }

        public async Task<RemoveClassroomCommandResponse> Handle(RemoveClassroomCommandRequest request, CancellationToken cancellationToken)
        {
            await _writeRepository.RemoveAsync(request.Id);
            await _writeRepository.SaveAsync();

            return new RemoveClassroomCommandResponse()
            {
                Message = "Classroom Removed Successfully"
            };

        }
    }
}
