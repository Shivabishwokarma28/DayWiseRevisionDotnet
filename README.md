# DayWiseRevisionDotnet
Revision of code and better understanging

Day 19: 

1. Razor Syntax
   
Razor is the markup language used to embed C# code into HTML.

  ->Symbol: The @ character is the "switch" that tells the engine to stop reading HTML and start reading C#.

  ->Inline Expressions: Used to output a single value (e.g., <h1>Welcome, @Model.Name</h1>).

  ->Code Blocks: Wrapped in @{ ... } for logic that doesn't immediately output text, like declaring variables or calculating values.

  ->Control Structures: Using @if for conditions and @foreach for loops directly in the HTML.

2. Razor Views (.cshtml)
   
These are the individual pages of your application.

  ->File Extension: .cshtml (C-Sharp + HTML).

  ->Location: They follow a strict naming convention: Views/[ControllerName]/[ActionName].cshtml.

  ->Role: They receive a Model from the Controller and use it to build the UI.

3. Layout Views (_Layout.cshtml)
To avoid repeating code like the Navbar, Header, and Footer on every page, you use a Layout.

  ->The Shell: It contains the <html>, <head>, and <body> tags.

  ->@RenderBody(): A mandatory placeholder in the Layout where the content of the specific Action View is injected.

  ->@RenderSection(): An optional placeholder for page-specific scripts or CSS.

4. ViewStart (_ViewStart.cshtml)
This file is used to set global configurations for all views in a folder.

  ->Automatic Linking: Instead of writing Layout = "_Layout"; on every single page, you write it once in _ViewStart.

  ->Execution: It runs before any other view code, ensuring the layout is applied automatically.

5. ViewImports (_ViewImports.cshtml)
This file centralizes the "Using" statements for your views.

  ->Cleanliness: It prevents you from having to type @using YourProject.Models at the top of every file.

  ->Tag Helpers: It is the standard place to enable Tag Helpers (like asp-action or asp-controller) for the entire project.

6. Partial Views
Partial Views are reusable "mini-pages" or widgets.

  ->Purpose: To break a large, complex page into smaller, manageable pieces (e.g., a _LoginPartial or _ProductCard).

  ->Benefit: They promote the DRY (Don't Repeat Yourself) principle. You write the HTML once and use it in multiple views using the <partial> tag.

7. The Interview Aspect (Quick Recap)
If an interviewer asks about Day 19 topics, focus on the View Execution Order:

  ->_ViewImports loads the namespaces.

  ->_ViewStart sets the layout.

  ->The Action View (e.g., Index.cshtml) generates its specific HTML.

  ->The _Layout wraps that HTML into the final page sent to the browser.
