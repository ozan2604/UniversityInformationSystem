# ?? University Information System – BIM308

This project is developed for **BIM308 - Web Server Programming** course.  
It is a RESTful API built using **Onion Architecture** with ASP.NET Core and Entity Framework Core.

The project was done with .net 9, normally the swagger integration was removed, but I integrated it into the code to make it easy to use. After running the project, please paste
https://localhost:7263/swagger/index.html into the browser and open the swagger!

or if you want to use postman, use this link https://localhost:7263/api/

You can connect to database with both local db and normal ConnectionString. Just run the project for local db.  
For the other way, just change the ConnectionString in appsetting.json

---

## ?? Due Date
**April 6, 2025**

---

## ?? Technologies Used

- ASP.NET Core Web API
- Entity Framework Core
- MediatR (CQRS Pattern)
- Repository Design pattern
- Swagger / Swashbuckle
- MS Sql - Local DB
- Onion Architecture
  - Core
  - Infrastructure
  - Presentation 
	


---

## ?? Project Structure

```plaintext
UniversityAPI/
??? Domain/             # Core entities (Student, Course, Classroom)
??? Application/        # Commands, Queries, Interfaces
??? Persistence/        # EF Core, Repositories, Context, Seed Data
??? WebAPI/             # Controllers, Swagger, Program.cs
??? README.md
