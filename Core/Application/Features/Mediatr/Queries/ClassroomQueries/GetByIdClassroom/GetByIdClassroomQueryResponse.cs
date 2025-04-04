using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Queries.ClassroomQueries.GetByIdClassroom
{
    public class GetByIdClassroomQueryResponse : BaseEntity
    {
        public string ClassroomName { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
    }
}
