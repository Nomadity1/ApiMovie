Small web app to practice setting up an API
Process:

Open the MS EF Core web API project template in Visual Studio
Create models folder and model classes
Install Nuget package (MS.EFCore, MS.EFCore.SqlServer, MS.EFCore.Tools, MS.EFCore.Design)
Create database class (AppDbContext.cs)
Define connection string (AppSettings.json)
Establish connection to the database class in the Main program (use connection string)
Create database through the Packager Manager Console (add-mgration InitialCreate) (update-database)
Add Controller (MovieController)
Add DTO:s
Test run SOURCE: https://localhost:7128/swagger/index.html 
