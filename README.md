# DayWiseRevisionDotnet
Revision of code and better understanging

Day 28:

1. Identity Implementation (The "Security" Layer)
   I have moved from the theory of Identity to building the actual workflow for your users:

  ->Registration: Using UserManager<T> to safely store user data and hash passwords.

  ->Login/Logout: Using SignInManager<T> to handle authentication cookies and session management.

  ->The Workflow: You now understand how to protect specific pages so that only logged-in users (or specific Roles like "Admin") can access them.

2. AJAX (The "Interactive" Layer)
I have learned how to break the "Refresh Cycle" of traditional web apps.

  ->The Concept: Using JavaScript to send background requests to your API while the user stays on the same page.

  ->The Benefit: Fast, smooth user experiences (like liking a movie or adding food to a cart) without the screen flickering white or reloading.

  ->Tools: Using the fetch() API or jQuery $.ajax to call your backend controllers.

3. Docker (The "Infrastructure" Layer)
   I’ve started using "Containerization," which is how the biggest tech companies in the world manage their apps.

The "Why": You solved the environment problem. Your code now carries its own "suitcase" (the container) with everything it needs to run.

Container: The "Running" version of your app.
