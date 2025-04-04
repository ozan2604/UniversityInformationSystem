# University Information System – BIM308

This project is developed for **BIM308 - Web Server Programming** course.  
It is a RESTful API built using **Onion Architecture** with ASP.NET Core and Entity Framework Core.

The project was done with .NET 9. Normally Swagger integration was removed, but I added it again for testing purposes.  
After running the project, please open the link below in your browser to use Swagger UI:

👉 [https://localhost:7263/swagger/index.html](https://localhost:7263/swagger/index.html)

Or, if you prefer Postman, use the base URL:

👉 [https://localhost:7263/api/](https://localhost:7263/api/)

You can connect to the database using either **LocalDB** or a custom **ConnectionString**.  
For custom connection, just modify `appsettings.json`.

---

## Due Date

**April 6, 2025**

---

## Technologies Used

- ASP.NET Core Web API
- Entity Framework Core
- MediatR (CQRS Pattern)
- Repository Design Pattern
- Swagger / Swashbuckle
- MS SQL – LocalDB
- Onion Architecture:
  - Core
  - Infrastructure
  - Presentation

---

## Project Structure

```plaintext
UniversityAPI/
├── Domain/             # Core entities (Student, Course, Classroom)
├── Application/        # Commands, Queries, Interfaces
├── Persistence/        # EF Core, Repositories, Context, Seed Data
├── WebAPI/             # Controllers, Swagger, Program.cs
└── README.md
