using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Queries.StudentQueries.GetByIdStudent
{
    public class GetByIdStudentQueryResponse : BaseEntity
    {
        public string IdentityNumber { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
