# DayWiseRevisionDotnet
Revision of code and better understanging

Day 18:

1. Advanced Routing: Attribute Routing
While Conventional Routing (Day 17) uses a general template in Program.cs,
Attribute Routing allows you to define routes directly on your Controller classes or Action methods.

  ->The Concept: It gives you "Fine-Grained" control. You decide exactly what the URL looks like.

  ->The Syntax: Uses the [Route("path")] attribute.

  ->Why use it? It is the standard for REST APIs because it allows for clean, descriptive URLs (e.g., [Route("api/students/{id}")]).

2. Map Methods (Minimal APIs)
You explored the "Map" family of methods. These are used to handle specific HTTP Verbs directly in the Program.cs file without needing a full Controller.

  ->MapGet: To retrieve/read data.

  ->MapPost: To create/submit new data.

  ->MapPut: To update existing data.

  ->MapDelete: To remove data.

  ->MapMethods: To handle multiple specific verbs at once.

3. Controllers & Action Results
You dived deeper into the "Brain" of the application—the Controller—and the different ways it can answer a request.

The Controller Class: Inherits from Controller base class to get access to ViewData, Json(), and Redirect().

  ->Action Methods: The public methods that handle the "Action."

  ->Diversity of Results: You learned that an Action doesn't just return HTML. It can return:

  ->ViewResult: HTML for the browser.

  ->JsonResult: Pure data for mobile apps or JavaScript.

  ->ContentResult: Plain text.

  ->FileResult: A downloadable file (PDF, Image).

  ->RedirectResult: Sending the user to a new URL.

4. Non-Action Methods
You learned how to protect your code.

  ->Definition: A public method in a controller that is not an endpoint.

  ->The Guard: Using the [NonAction] attribute to tell the routing engine to ignore the method.

  ->The Use Case: Helper logic that needs to be public for testing but should never be triggered by a URL.

5. Postman Setup & Testing
Since you cannot test POST, PUT, or DELETE requests simply by typing a URL into Chrome, you introduced Postman.

The Tool: A specialized "browser" for developers to test APIs.

  ->The Workflow:

  ->Set the Verb (GET/POST).

  ->Enter the URL.

  ->Set the Body (usually JSON).

  ->Inspect the Status Code (200 OK, 404 Not Found, etc.).
