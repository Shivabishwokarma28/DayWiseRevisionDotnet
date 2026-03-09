# DayWiseRevisionDotnet
Revision of code and better understanging

Day 22:
1. The Core: Model Binding


  -->Definition: The process of mapping HTTP request data (Form, Route, QueryString) to Action method parameters or Model properties.

  -->The "Handshake": It relies on the Name attribute in HTML matching the Property Name in C#.

  -->Automation: It handles Type Conversion (e.g., turning the text "22" into an int) and Instance Creation (calling new Student() for you).

2. Form & Input Controls
   I have explored how different HTML elements map to C# data types:

  -->Labels (<label asp-for="...">): Provides accessibility and links the caption to the input.

  -->TextAreas (<textarea asp-for="...">): Used for multi-line strings (like a Student Bio or Address).

  -->Checkboxes: Bind to bool properties. ASP.NET Core automatically handles the true/false logic.

3. Selection Controls (The "Pickers")
These are crucial for keeping your data clean by limiting what the user can enter.

  -->Radio Buttons: Used for picking one option from a small set (e.g., Gender).

  -->Rule: All buttons in a group share the same asp-for but have different value attributes.

  -->DropDownList (<select>): Used for picking one option from a larger list (e.g., Branch/Faculty).

  -->Mechanism: Uses asp-for to save the selection and asp-items (via SelectListItem) to populate the list.
4. •	Login Web Project from scratch
