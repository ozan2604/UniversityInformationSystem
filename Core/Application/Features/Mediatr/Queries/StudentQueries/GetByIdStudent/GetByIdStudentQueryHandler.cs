using Application.Repositories.StudentRepositories;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Queries.StudentQueries.GetByIdStudent
{
    public class GetByIdStudentQueryHandler : IRequestHandler<GetByIdStudentQueryRequest, GetByIdStudentQueryResponse>
    {
        private readonly IStudentReadRepository _readRepository;

        public GetByIdStudentQueryHandler(IStudentReadRepository readRepository)
        {
            _readRepository = readRepository;
        }

        public async Task<GetByIdStudentQueryResponse> Handle(GetByIdStudentQueryRequest request, CancellationToken cancellationToken)
        {
            Student student = await _readRepository.GetByIdAsync(request.Id, false);
            return new()
            {
                Id = student.Id,
                FullName = student.FullName,
                Email = student.Email,
                IdentityNumber = student.IdentityNumber,
                CreatedTime = student.CreatedTime,
                UpdatedTime = student.UpdatedTime,
            };
        }
    }
}
