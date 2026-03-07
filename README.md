# DayWiseRevisionDotnet
Revision of code and better understanging

Day 17: 
1. Middleware in ASP.NET Core
   
 -->Definition: Software components assembled into an application pipeline to handle HTTP requests and responses.

 -->The Pipeline: A "Two-Way" street where the request flows in through components (like logging, security, and routing) and the response flows back out through         them.

 -->Order of Execution: The sequence in Program.cs is critical. A request hits the first middleware defined and moves down; the response moves back up.

 -->Short-Circuiting: The ability of a middleware to stop a request (e.g., if a user is not authenticated) so it never reaches the controller.

2. Use vs. Run Middleware
   
 -->The Use Method:

Adds a middleware that can pass the request to the next component.

Uses a RequestDelegate (next) to keep the pipeline moving.

 -->Concept: The "Pass-through" or "Gateway."

The Run Method:

Adds a Terminating middleware.

Does not have a next delegate; it handles the request and stops.

 -->Concept: The "Dead End" or "End of the Line."

3. Routing (The GPS)
 -->Definition: The mechanism that maps an incoming URL to a specific Controller and Action.

 -->Role: It extracts data from the URL (like an ID) and passes it to your C# methods.

 -->Conventional Routing:

 -->Defined globally in Program.cs.

 -->Follows a standard template: {controller}/{action}/{id?}.

 -->Benefit: Centralized control for the whole application.

4. Controllers & Views (The Brain & UI)
 -->Creating Controllers:

 -->Classes that inherit from the Controller base class.

 -->They act as the "middleman" between the Model (data) and the View (display).



Action Methods:

 -->Public methods inside a Controller that handle specific requests.

 -->Usually return an IActionResult (like a View, a File, or JSON).


Returning Views:

 -->Using the return View(); statement.

The system automatically looks for a .cshtml file in the Views/[ControllerName]/ folder that matches the Action name.
