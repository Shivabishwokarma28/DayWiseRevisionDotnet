# DayWiseRevisionDotnet
Revision of code and better understanging

Day 15:
1. Entity Framework Core (The Magic ORM)
   Instead of writing SELECT * FROM Students, you simply use C# collections. EF Core handles the SQL generation, connection opening/closing, and data mapping for you.
  ->Core Building Blocks:The Model: A standard C# class that represents a database table.
  ->DbContext: The "Heart" of EF Core. It represents a session with the database and allows you to query and save data.
  ->DbSet: A property in your DbContext that represents a specific table (e.g., DbSet<Student>).

2. Visual Studio SetupTo get EF Core working, We need to add specific "engines" to your project using the NuGet Package Manager.
   
  ->Step-by-Step Installation:Right-click your Project in Solution Explorer $\rightarrow$ Manage NuGet Packages.
  Search for and install: 
  **Microsoft.EntityFrameworkCore.SqlServer: The provider for SQL Server.
  **Microsoft.EntityFrameworkCore.Tools: Enables the Package Manager Console commands.
  **Microsoft.EntityFrameworkCore.Design: Required for creating migrations.Creating your first DbContext:
  
  
  public class SchoolContext : DbContext
{
    // This represents the Students table
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Define your connection string here
        optionsBuilder.UseSqlServer("Server=.;Database=SchoolDB;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
3. The Migration WorkflowIn EF Core, you change the Code first, and the database follows. 
This is managed via Migrations.
  ->Add-Migration InitialCreate: Creates a C# "blueprint" of what the database should look like.
    ->Update-Database: Executes that blueprint against SQL Server to create the actual tables.
    
    
4. Form Design (UI for CRUD)For your project, we will design a Windows Form (or Web Form) that allows users to interact with this data model. A professional CRUD form usually contains:
     ->DataGridView: To display all records (Read).
     ->TextBoxes: For user input (Name, Age, Email).
     Buttons:
     ->Add: context.Students.Add(newStudent); context.SaveChanges();
     ->Update: Modify the object and call context.SaveChanges();
     ->Delete: context.Students.Remove(student); context.SaveChanges();

5. The "Senior" Insight:
    Why use EF Core?
     ->Interviewer: "If ADO.NET is faster, why do we use EF Core in almost every modern project?
   "The "Senior"
Answer:"It's about Maintainability and Developer Productivity. EF Core handles SQL Injection protection by default, provides compile-time checking for your queries (so you don't have typos in your SQL strings), and makes refactoring much easier. In 90% of business applications, the speed of delivery is more important than the millisecond performance gain of raw ADO.NET."
