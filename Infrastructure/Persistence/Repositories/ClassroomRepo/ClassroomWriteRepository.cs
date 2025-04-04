
using Application.Repositories.ClassroomRepositories;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.ClassroomRepo
{
    public class ClassroomWriteRepository : WriteRepository<Classroom>, IClassroomWriteRepository
    {
        public ClassroomWriteRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
