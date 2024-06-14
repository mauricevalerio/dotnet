# React + ASP.NET Core Web API

ASP.NET Core practice [ASP.NET Core Web API](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio) with basic React + Vite web application for the front-end.

## Prerequisites
- [Visual Studio](https://visualstudio.microsoft.com/vs/) or [VS Code](https://code.visualstudio.com/)
- [SQL Server Management Studio](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)
- [.NET SDK](https://dotnet.microsoft.com/en-us/download) includes .NET Core CLI
- [VS Code](https://code.visualstudio.com/) or any code editors for front-end code
- [Node.js](https://nodejs.org/en) for node package dependencies for front-end code

## Setup

### Web API
- Build project to update NuGet depedencies.
    - Visual Studio - `Ctrl+Shift+B`
    - .NET Core CLI - `dotnet build`
- Run EF Core Migration to Update MS SQL Database:
    - Visual Studio
        - `Add-Migration InitialCreate`
        - `Update-Database`
    - .NET Core CLI
        - `dotnet ef migrations add InitialCreate`
        - `dotnet ef database update`
- In `Program.cs`, change middleware parameters for CORS specifically on line 15 to reflect where you serve your front-end web app on your localhost server.

### React Front-End
- Install node package dependencies `npm install`
- Under `api/index.ts`, change line 3 to reflect where you serve your web API on your localhost server.
