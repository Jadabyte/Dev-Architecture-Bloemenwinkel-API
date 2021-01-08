# Flower Store .NET CORE 3.1 API

## Setup
###### Required Software: 
- [.NET Core 3.1+](https://dotnet.microsoft.com/download)
- A local MySQL server
- A visual tool for MySQL (phpMyAdmin, MysQL Workbench, etc.)
- Visual Studio with C# support

###### Running the API:
1. Open 'Developer Powershell' within Visual Studio or 'Windows PowerShell' and change your directory to this project.
2. Insert your MySQL connection into [appsettings.json](FlowerStore/appsettings.json)
3. Make sure your MySQL server is running
4. Run 'dotnet ef database update' to create a new database and tables. This will also seed the database with predefined data.
5. Run 'dotnet run' to start the API
6. In a browser, go to http://localhost:5000/swagger/index.html to try out the API

## Troubleshooting
In case of errors, run these commands to install packages, and try again
- dotnet add package MySql.Data.EntityFrameworkCore
- dotnet add package Swashbuckle.AspNetCore.SwaggerGen
- dotnet add package Swashbuckle.AspNetCore.SwaggerUI