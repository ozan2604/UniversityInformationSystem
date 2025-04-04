using Application.Features.Mediatr.Commands.StudentCommands.RemoveStudent;
using Application.Repositories.StudentRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Queries.StudentQueries.GetAllStudent
{
    public class GetAllStudentQueryHandler : IRequestHandler<GetAllStudentQueryRequest, List<GetAllStudentQueryResponse>>
    {
        private readonly IStudentReadRepository _readRepository;

        public GetAllStudentQueryHandler(IStudentReadRepository readRepository)
        {
            _readRepository = readRepository;
        }

        public async Task<List<GetAllStudentQueryResponse>> Handle(GetAllStudentQueryRequest request, CancellationToken cancellationToken)
        {
            var response =  _readRepository.GetAll(false).Select(p => new GetAllStudentQueryResponse
            {
                Id = p.Id,
                FullName =  p.FullName,
                IdentityNumber = p.IdentityNumber,
                Email = p.Email,
                CreatedTime = p.CreatedTime,
                UpdatedTime = p.UpdatedTime,
                Courses = p.Course.Select(c => c.CourseCode).ToList()

            }).ToList();

            return response;
        }
    }
}
