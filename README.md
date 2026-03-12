# DayWiseRevisionDotnet
Revision of code and better understanging

Day 25:

1. Database Integration & EF Core
  ->Connection Strings: Configuring appsettings.json to link your MVC application to SQL Server.

  ->DbContext Configuration: Implementing a class (likely AppDbContext) that inherits from DbContext to act as the bridge between your C# models and the database.

  ->Migrations: Using Entity Framework Core commands (Add-Migration and Update-Database) to create the user tables in SQL Server.

2. User Authentication Logic

  ->Login & Registration Models: Creating ViewModels specifically for the UI (e.g., LoginViewModel, RegisterViewModel) to handle data transfer without exposing your main database entities.

  ->Password Security: Handling password inputs securely (ensuring they aren't stored as plain text) and using [DataType(DataType.Password)] annotations.

  ->Session/Cookie Management: Implementing the logic that keeps a user "logged in" after the form is submitted.

3. MVC Architecture for Security

   ->Account Controller: Building a controller specifically for authentication actions like Login, Register, and Logout.

  ->HTTP POST Actions: Writing controller methods marked with [HttpPost] to process form data securely.

  ->View Components: Designing the Login.cshtml and Register.cshtml pages using ASP.NET Core Tag Helpers (asp-for, asp-action, asp-controller).

Specific Folder Highlights
  ->Controllers/: Contains the logic that checks if the username and password match the database records.

  ->Models/: Includes the User entity and the ViewModels used to validate form input (like [Required] and [EmailAddress]).

  ->Views/Account/: The actual HTML/Razor pages where users enter their credentials.

  ->wwwroot/: Your CSS and Bootstrap files that style the login box to look professional.

