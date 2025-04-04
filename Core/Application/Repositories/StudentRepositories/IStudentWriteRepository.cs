using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories.StudentRepositories
{
    public interface IStudentWriteRepository : IWriteRepository<Student>
    { 
    }
}
