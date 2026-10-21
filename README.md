# ASPNETCoreRazorPageSchoolApp

SE Lab 7 - Exercise 1: School Management Web App with ASP.NET Core (.NET 10) Razor Pages, EF Core, Database First (existing `SchoolDB`).

- `Models/SchoolContext.cs` + entity classes (Department, Instructor, Course, Student, Enrollment)
- Connection string `SchoolDBConnectionString` in `appsettings.json`, DbContext registered in `Program.cs`
- CRUD Razor Pages scaffolded with *Razor Pages using Entity Framework (CRUD)* under `Pages/<Entity>s`
- Menu in `Pages/Shared/_Layout.cshtml`

Run `Database/SchoolDB.sql` on `.\SQLEXPRESS`, open `SchoolAppCore.slnx`, press F5.
