using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Student :  BaseEntity
    {
        public string IdentityNumber { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public List<Course> Course { get; set; }

    }
}
