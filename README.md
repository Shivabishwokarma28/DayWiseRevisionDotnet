# DayWiseRevisionDotnet
Revision of code and better understanging

Day 23: 
1. Model Validation (The "Security Guard")
   I have learned how to use Data Annotations to set rules for your data before it ever reaches the database.
   
  Built-in Attributes:
    ->[Required]: Field cannot be null.
    ->[StringLength]: Controls character limits.
    ->[Range]: Sets numeric boundaries (e.g., Age 18–60).
    ->[EmailAddress], [Phone], [Url]: Validates specific formats.
    ->[Compare]: Matches two fields (e.g., Password and Confirm Password).
  The Logic:
  I have learned that Server-side validation (ModelState.IsValid) is the only way to truly secure an app, while Client-side validation (jQuery) is for a faster User Experience (UX).
  
  2. Entity Framework Core (The "Bridge")
     I have explored the world of ORMs (Object-Relational Mappers), which allow you to talk to a SQL database using C# instead of raw SQL strings.
Key Packages:
Microsoft.EntityFrameworkCore (The Engine).
Microsoft.EntityFrameworkCore.SqlServer (The Database Driver).
Microsoft.EntityFrameworkCore.Tools & .Design (The Migration Toolkit).
  ->The DbContext: You created the "Control Center" that coordinates the connection between your C# DbSet<T> and the SQL Tables.

3. Programming Approaches:
    Code First vs. Database First
   I have compared the two main ways to build a database-driven application:
     ->Code First (The Modern Way):Workflow: C# Class ---> Migration  ---> SQL Table.
   Tool: Add-Migration and Update-Database.
   Benefit: Your database schema is version-controlled in Git.


     ->Database First (The Legacy Way):Workflow: SQL Table  ---> Scaffolding  ---> C# Class.
   Tool: dotnet ef dbcontext scaffold.Benefit: Best for existing databases managed by DBAs.
