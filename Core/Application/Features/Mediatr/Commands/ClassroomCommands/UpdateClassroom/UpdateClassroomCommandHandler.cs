using Application.Features.Mediatr.Commands.ClassroomCommands.UpdateClassroom;
using Application.Repositories.ClassroomRepositories;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Commands.ClassroomCommands.UpdateClassroom
{
    
        public class UpdateClassroomCommandHandler : IRequestHandler<UpdateClassroomCommandRequest, UpdateClassroomCommandResponse>
        {
            private readonly IClassroomWriteRepository _courseWriteRepository;
            private readonly IClassroomReadRepository _courseReadRepository;

            public UpdateClassroomCommandHandler(IClassroomWriteRepository courseWriteRepository, IClassroomReadRepository courseReadRepository)
            {
                _courseWriteRepository = courseWriteRepository;
                _courseReadRepository = courseReadRepository;
            }

            public async Task<UpdateClassroomCommandResponse> Handle(UpdateClassroomCommandRequest request, CancellationToken cancellationToken)
            {
                Classroom course = await _courseReadRepository.GetByIdAsync(request.Id);
                course.ClassroomName = request.ClassroomName;
                course.Capacity = request.Capacity;
                course.Description = request.Description;
                course.UpdatedTime = DateTime.Now;

                await _courseWriteRepository.SaveAsync();

                return new UpdateClassroomCommandResponse
                {
                    Message = "Classroom Updated Successfully"
                };

            }
        }
    }

