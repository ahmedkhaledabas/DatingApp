# DatingApp API

A small ASP.NET Core 8 Web API demonstrating a layered backend structure with Entity Framework Core and SQL Server.

## Tech stack

- .NET 8 / ASP.NET Core Web API
- Entity Framework Core 8
- SQL Server
- Swagger / OpenAPI

## Project structure

- `Controllers` — HTTP endpoints and response codes
- `Services` — application-level mapping and orchestration
- `Repository` — database access
- `Data` — EF Core DbContext and migrations
- `DTOs` — API response models

## Getting started

1. Install the .NET 8 SDK and SQL Server (LocalDB is suitable for local development).
2. Configure the connection string using .NET user secrets or environment variables. Do not commit credentials.

   Example environment variable:

   ```text
   ConnectionStrings__Default=Server=(localdb)\MSSQLLocalDB;Database=DatingApp;Trusted_Connection=True;TrustServerCertificate=True
   ```

3. From the repository root, apply the existing EF Core migrations:

   ```bash
   dotnet tool install --global dotnet-ef
   dotnet ef database update --project DatingApp/DatingApp.csproj
   ```

4. Run the API:

   ```bash
   dotnet run --project DatingApp/DatingApp.csproj
   ```

5. In the Development environment, open the Swagger URL printed by the application.

## Endpoints

| Method | Endpoint | Description |
| --- | --- | --- |
| GET | `/api/users` | List users |
| GET | `/api/users/{id}` | Get a user by ID; returns 404 when no user exists |
| GET | `/health` | Application health endpoint |

## Notes

- Database configuration is read through ASP.NET Core configuration; no connection string is hard-coded in source code.
- Read-only EF Core queries use no-tracking behavior.
- Cancellation tokens are passed from HTTP requests through the service and repository layers.
- This is a portfolio/demo project, not a production-ready identity or dating platform. Authentication, authorization, write operations, pagination, and production deployment hardening are not implemented yet.
