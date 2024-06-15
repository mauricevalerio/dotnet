# Text Search Vue + ASP.NET Core Web API

This was a problem provided to me back in 2022 for a entry level .NET developer role and unfortunately was not able to get it done that time since my knowledge with C# and .NET was outdated.

Went back and finished it this 2024 since I'm currently refreshing my knowledge with C# and .NET and found that it was an easy project 😞. Anyway glad that I came back to it and finished the project using Vue and not Angular which was the requirement. 😂

## Software Requirements
- [Visual Studio](https://visualstudio.microsoft.com/vs/) or [VS Code](https://code.visualstudio.com/)
- [SQL Server Management Studio](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)
- [.NET SDK](https://dotnet.microsoft.com/en-us/download) includes .NET Core CLI
- [VS Code](https://code.visualstudio.com/) or any code editors for front-end code
- [Node.js](https://nodejs.org/en) for node package dependencies for front-end code

## Build Project

### Web API
- Build project to update NuGet depedencies.
    - Visual Studio - `Ctrl+Shift+B`
    - .NET Core CLI - `dotnet build`
- In `Program.cs`, change middleware parameters for CORS specifically on line 14 to reflect where you serve your front-end web app on your localhost server.

### Vue Front-End
- Install node package dependencies `npm install`
- Under `utils/api.js`, change line 1 to reflect where you serve your web API on your localhost server.
- NOTE: Don't forget to append at the end the `?`


## Problem Description
Implement a text search web API written in Microsoft C# .NET Core deployed to in a local IIS and write the front-end in Angular 13 using Visual Studio Code. For Mac or Linux please implement the web API written in Java and deploy to Apache Tomcat and write the front-end in Angular 13 using Visual Studio Code.

### Problem Requirements
- The ability to search for text
- The ability to do a full word search
- The ability to do case sensitive search

### Inputs
- String - A sentence
- String - The text to search in the sentence
- Boolean - Full word search
- Boolean - Case sensitivity search

### Outputs
- Integer - How many times the searched word is in the sentence

### Testing
- 1st input: "Coders who code don't always eat cod. Exclaimed the coder who codes CODE."
- example 2nd input:
    - Test 1
        - Text to search: Cod
        - Full word = false
        - Case sensitive = false
            - Returns 6
    - Test 2
        - Text to search: .
        - Full word = false
        - Case sensitive = false
            - Returns 2
    - Test 3
        - Text to search: Cod
        - Full word = true
        - Case sensitivity = true
            - Returns 0
    - Test 4
        - Text to search: CODE.
        - Full word = true
        - Case sensitivity = true
            - Returns 1
    - Test 5
        - Text to search: don't always
        - Full word = true
        - Case sensitivity = true
            - Returns 1