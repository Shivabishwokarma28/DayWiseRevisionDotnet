# DayWiseRevisionDotnet
Revision of code and better understanging

Day 24: 

1. State Management: Sessions
   I have learned that since HTTP is "stateless" (it forgets every request immediately), we use Sessions to bridge the gap.

  ->The Concept: Storing user-specific data on the Server RAM while the user browses.

  ->The "Key" (Cookies): Sessions rely on a small cookie (.AspNetCore.Session) stored in the browser that acts as the "ID Card" to unlock the server-side data.

  ->The Configuration: You learned the "Trio" required in Program.cs:

  ->AddDistributedMemoryCache(): The physical storage in RAM.

  ->AddSession(): The configuration (timeout, security settings).

  ->UseSession(): The activation in the middleware pipeline.

2. The Login Workflow
You built a secure gatekeeper for your application by combining EF Core with Sessions.

  ->Authentication: Using LINQ to check if a user’s Email and Password exist in the SQL database.

  ->Session Injection: Once verified, you store only essential data (like UserId or UserEmail) in the session.

  ->Access Control: Checking HttpContext.Session.Get() at the top of protected Controller actions to redirect "strangers" back to the login page.

3. Stateful vs. Stateless (Session vs. JWT)
   I have explored the critical architecture choice between traditional web apps and modern APIs.

  Sessions (Stateful):

  ->Pro: Easy to implement, built-in logout.

  ->Con: Requires server memory (DistributedMemoryCache); harder to scale across multiple servers.

  JWT (Stateless):

  ->Pro: No server memory required; great for Web APIs and Mobile apps.

Con: Harder to "revoke" a token once it's issued.
  ->
4. Middleware Pipeline Order
I have learned that the order of code in Program.cs is a "Security Pipeline."

Rule: UseSession() must come after UseRouting() (so it knows where the user is going) but before UseAuthorization() (so it can tell the security system who the user is).
