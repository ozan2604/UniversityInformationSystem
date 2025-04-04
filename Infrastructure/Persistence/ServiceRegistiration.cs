
using Application.Repositories.ClassroomRepositories;
using Application.Repositories.CourseRepositories;
using Application.Repositories.StudentRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repositories.ClassroomRepo;
using Persistence.Repositories.CourseRepo;
using Persistence.Repositories.StudentRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class ServiceRegistiration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(Configuration.ConnectionString));

            

            services.AddScoped<IStudentWriteRepository, StudentWriteRepository>();
            services.AddScoped<IStudentReadRepository, StudentReadRepository>();

            services.AddScoped<ICourseWriteRepository, CourseWriteRepository>();
            services.AddScoped<ICourseReadRepository, CourseReadRepository>();

            services.AddScoped<IClassroomWriteRepository, ClassroomWriteRepository>();
            services.AddScoped<IClassroomReadRepository, ClassroomReadRepository>();

            


        }
    }
}
