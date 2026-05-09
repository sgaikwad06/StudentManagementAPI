# Student Management API

This is a Student Management Web API project developed using ASP.NET Core Web API, SQL Server, and Entity Framework Core.

The project allows users to perform CRUD operations on student records such as:

- Add Student
- View Students
- Update Student
- Delete Student

## Technologies Used

- ASP.NET Core Web API
- C#
- SQL Server
- Entity Framework Core
- Swagger UI
- JWT Authentication

## Features

- REST API implementation
- Database connectivity with SQL Server
- CRUD operations
- JWT Token Authentication
- Swagger API testing

## API Endpoints

### Student APIs
- GET /api/Student
- POST /api/Student
- PUT /api/Student/{id}
- DELETE /api/Student/{id}

### Authentication API
- POST /api/Auth/login

## Sample Login

Username: admin

Password: admin

## Database

Database Name: StudentDB

Table Name: Students

## How to Run the Project

1. Clone the repository
2. Open project in Visual Studio
3. Configure SQL Server connection string in appsettings.json
4. Build and run the project
5. Open Swagger using:
   https://localhost:7081/swagger
