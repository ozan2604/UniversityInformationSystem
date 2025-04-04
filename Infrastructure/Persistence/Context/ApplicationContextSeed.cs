using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public static class ApplicationContextSeed
    {
        public static async Task SeedAsync(ApplicationContext context)
        {
            
            if (!context.Classrooms.Any())
            {
                var classroom1 = new Classroom
                {
                    Id = Guid.NewGuid(),
                    ClassroomName = "B6",
                    Description = "Computer Engineering Ground Floor",
                    Capacity = 60
                };

                var classroom2 = new Classroom
                {
                    Id = Guid.NewGuid(),
                    ClassroomName = "C1",
                    Description = "Software Engineering First Floor",
                    Capacity = 40
                };

                var course1 = new Course
                {
                    Id = Guid.NewGuid(),
                    CourseCode = "BIM308",
                    Title = "Web Server Programming",
                    ClassroomId = classroom1.Id,
                    Classroom = classroom1
                };

                var course2 = new Course
                {
                    Id = Guid.NewGuid(),
                    CourseCode = "BIM439",
                    Title = "Cloud Computing",
                    ClassroomId = classroom2.Id,
                    Classroom = classroom2
                };

                var course3 = new Course
                {
                    Id = Guid.NewGuid(),
                    CourseCode = "BBO102",
                    Title = "Introduction to Programming",
                    ClassroomId = classroom1.Id,
                    Classroom = classroom1
                };

                var student = new Student
                {
                    Id = Guid.NewGuid(),
                    IdentityNumber = "44488883333",
                    FullName = "Emin Talip Demirkiran",
                    Email = "etd@eskisehir.edu.tr",
                    Course = new List<Course> { course1, course2, course3 }
                };



                // Her kursa bu öğrenciyi de bağla
                course1.Student = new List<Student> { student };
                course2.Student = new List<Student> { student };
                course3.Student = new List<Student> { student };

                context.Classrooms.AddRange(classroom1, classroom2);
                context.Courses.AddRange(course1, course2, course3);
                context.Students.Add(student);

                await context.SaveChangesAsync();
            }
        }  
    }
}
