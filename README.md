# DayWiseRevisionDotnet
Revision of code and better understanging

Day 16:

1. ASP.NET vs. ASP.NET Core
   
You learned the history and the "why" behind the shift to Core.

  ->ASP.NET (Legacy): Windows-only, tied to IIS, and often "heavy" (Web Forms).

  ->ASP.NET Core (Modern): Cross-platform (Linux/Mac/Windows), open-source, and extremely fast. It uses a Modular approach where you only add the features you need.

2. The MVC Pattern (Architecture)
We spent a lot of time on the Model-View-Controller pattern, using the Bank Teller and Smart TV analogies to understand "Separation of Concerns."

  ->Model: The Data and Logic (The "Vault").

  ->View: The UI/HTML (The "Lobby"). It is kept "Dumb" so it doesn't break when the database changes.

  ->Controller: The Coordinator (The "Teller"). It receives the user's request, talks to the Model, and delivers the View.

3. Loose Coupling & Senior Insights
   
We tackled a major interview concept: Why the View shouldn't talk to the Model.

  ->The Goal: To prevent "Spaghetti Code."

  ->he Benefit: You can swap out your database (Model) without ever having to rewrite your HTML/CSS (View). This makes the application easier to test and maintain.

4. ASP.NET Core Project Structure
   
We explored the "Standard Folders" that every professional ASP.NET Core project uses:

  ->Controllers/: Logic classes.

  ->Models/: Data classes (EF Core entities).

  ->Views/: Razor HTML files (.cshtml).

  ->wwwroot/: Static files like CSS and images.

  ->appsettings.json: Configuration and connection strings.

  ->Program.cs: The entry point where the Middleware Pipeline is built.
