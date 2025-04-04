using Application.Repositories.ClassroomRepositories;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Commands.ClassroomCommands.CreateClassroom
{
    public class CreateClassroomCommandHandler : IRequestHandler<CreateClassroomCommandRequest, CreateClassroomCommandResponse>
    {
        private readonly IClassroomWriteRepository _writeRepository;

        public CreateClassroomCommandHandler(IClassroomWriteRepository writeRepository)
        {
            _writeRepository = writeRepository;
        }

        public async Task<CreateClassroomCommandResponse> Handle(CreateClassroomCommandRequest request, CancellationToken cancellationToken)
        {
            await _writeRepository.AddAsync(new Classroom
            {
                ClassroomName = request.ClassroomName,
                Description = request.Description,
                Capacity = request.Capacity,
                CreatedTime = DateTime.Now,
                UpdatedTime = DateTime.Now
            }); 

           await _writeRepository.SaveAsync();

            return new()
            {
                Message = "Classroom Created Successfully"
            };


        }
    }
}
