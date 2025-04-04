using Application.Repositories;
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

namespace Application.Features.Mediatr.Commands.StudentCommands.CreateStudent
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommandRequest, CreateStudentCommandResponse>
    {
        private readonly IStudentWriteRepository _studentWriteRepo;
        private readonly ICourseReadRepository _courseReadRepo;

        public CreateStudentCommandHandler(
            IStudentWriteRepository studentWriteRepo,
            ICourseReadRepository courseReadRepo)
        {
            _studentWriteRepo = studentWriteRepo;
            _courseReadRepo = courseReadRepo;
        }

        public async Task<CreateStudentCommandResponse> Handle(CreateStudentCommandRequest request, CancellationToken cancellationToken)
        {
            
            var courses = _courseReadRepo.GetWhere(c => request.CourseIds.Contains(c.Id)).ToList();

            var student = new Student
            {
                IdentityNumber = request.IdentityNumber,
                FullName = request.FullName,
                Email = request.Email,
                CreatedTime = DateTime.Now,
                UpdatedTime = DateTime.Now,
                Course = courses 
            };

            await _studentWriteRepo.AddAsync(student);
            await _studentWriteRepo.SaveAsync();

            return new CreateStudentCommandResponse
            {
                Message = "Student Created Successfully"
            };
        }
    }
}
