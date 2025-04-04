
using Application.Repositories.ClassroomRepositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.ClassroomRepo
{
    public class ClassroomReadRepository : ReadRepository<Classroom>, IClassroomReadRepository
    {
        public ClassroomReadRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
