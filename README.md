# DayWiseRevisionDotnet
Revision of code and better understanging

Day 27:

Web API Server Construction:

  ->Built a dedicated Web API project.

  ->Implemented EF Core with SQL Server to manage your database.

  ->Created an ApiController that performs all four CRUD operations.

MVC Client Implementation:

  ->Built a separate MVC Web Application that acts as the "Client."

  ->Used HttpClient to connect the MVC project to the API project.

  ->Implemented logic to display API data in MVC Razor Views.

End-to-End CRUD Flow:

  ->Create: Sending data from an MVC Form → HttpClient → API → SQL Server.

  ->Read: SQL Server → API → HttpClient → MVC View.

  ->Update/Delete: Targeting specific IDs through the API pipeline.

Identity Framework Introduction:

  ->Integrated the IdentityDbContext.

  ->Learned the difference between Authentication (Login) and Authorization (Roles).
