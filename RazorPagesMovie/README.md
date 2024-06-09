# RazorPagesMovie

ASP.NET Core practice [ASP.NET Core Razor Pages Web App](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/?view=aspnetcore-8.0)

## Prerequisites
- [Visual Studio](https://visualstudio.microsoft.com/vs/) or [VS Code](https://code.visualstudio.com/)
- [SQL Server Management Studio](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)
- [.NET SDK](https://dotnet.microsoft.com/en-us/download) includes .NET Core CLI

### Setup
- Build project to update NuGet depedencies.
    - Visual Studio - `Ctrl+Shift+B`
    - .NET Core CLI - `dotnet build`
- Run EF Core Migration to Update MS SQL Database:
    - Visual Studio
        - `Remove-Migration`
        - `Add-Migration InitialCreate`
        - `Update-Database`
    - .NET Core CLI
        - `dotnet ef migrations remove`
        - `dotnet ef migrations add InitialCreate`
        - `dotnet ef database update`
- Database will be automatically seeded by the `Models/SeedData.cs`

