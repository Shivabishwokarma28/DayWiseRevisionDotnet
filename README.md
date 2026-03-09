# DayWiseRevisionDotnet
Revision of code and better understanging

Day 20:

1. Loose Data Transfer (The "Three Amigos")
These are used for small, non-essential pieces of information like page titles or status messages.

  ->ViewData:

****A Dictionary object (ViewDataDictionary).

****Uses string keys: ViewData["Title"] = "Home".

****Requires Type Casting in the View for any logic (e.g., (int)ViewData["Age"]).

  ->ViewBag:

****A Dynamic wrapper around ViewData.

****Uses dot notation: ViewBag.Title = "Home".

****No Casting required, but offers no IntelliSense or compile-time checking.

  ->TempData:

****Used to pass data across Redirects (survives one extra request).

****Perfect for "Task Deleted" or "Save Successful" notifications.

****Data is cleared automatically after the first time it is read.

2. Models in MVC
Models are the backbone of your application. They are simple C# classes (.cs) that represent your Domain Data.

  ->Purpose: To define the properties (ID, Name, Email) and business rules of your entities.

  ->POCO: Models are usually "Plain Old CLR Objects," meaning they are lightweight and easy to test.

  ->Validation: You learned that Models can use Data Annotations (like [Required]) to ensure data integrity.

3. Strongly Typed Views
This is the professional way to build views. Instead of guessing what data is coming in, the View explicitly declares its "Type."

  ->Directive: Uses @model Student at the top of the file.

  ->Access: Uses the uppercase @Model property to display data.

  ->Benefit: Provides IntelliSense and Compile-time safety. If you mistype a property name, the project won't build, preventing runtime crashes.

4. Repository Pattern
This is an architectural "Best Practice" that separates the Controller from the Data Source.

  ->The Interface (IStudentRepo): Defines what actions can be performed (Add, Delete, Get).

  ->The Implementation (StudentRepo): Contains the actual code to talk to a List or Database.

Why use it? It makes your app Decoupled and Testable. You can change your database type without ever touching your Controller code.

5. Mini Project 4: To-Do App
This project was the "Glue" that stuck all these concepts together.

  ->The Flow: You created a TodoItem Model, managed it via a TodoRepository, passed a list to a Strongly Typed View, and used TempData to show success alerts after adding or deleting tasks.
