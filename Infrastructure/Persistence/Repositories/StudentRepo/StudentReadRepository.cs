
using Application.Repositories.StudentRepositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.StudentRepo
{
    public class StudentReadRepository : ReadRepository<Student>, IStudentReadRepository
    {
        public StudentReadRepository(ApplicationContext context) : base(context)
        {
        }

        public override IQueryable<Student> GetAll(bool tracking = true)
        {
            var query = base.GetAll(tracking);
            return query.Include(s => s.Course);
        }
    }
}
