using Domain.Entities.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
        public class ApplicationContext : DbContext
        {
            public ApplicationContext(DbContextOptions options) : base(options)
            {
            }
            public DbSet<Course> Courses { get; set; }
            public DbSet<Student> Students { get; set; }
            public DbSet<Classroom> Classrooms { get; set; }

            public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
            {
                var datas = ChangeTracker.Entries<BaseEntity>();

                foreach (var data in datas)
                {
                    _ = data.State switch
                    {
                        EntityState.Added => data.Entity.CreatedTime = DateTime.UtcNow,
                        EntityState.Modified => data.Entity.UpdatedTime = DateTime.UtcNow,
                        _ => DateTime.UtcNow
                    };


                }
                return await base.SaveChangesAsync(cancellationToken);
            }
        }
}
