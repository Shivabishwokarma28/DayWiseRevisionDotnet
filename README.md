# DayWiseRevisionDotnet
Revision of code and better understanging

Day 26:

1. The API Fundamentals
  ->The Concept: A "Contract" or "Bridge" between systems.


  ->Real-World Logic: The Bike Company (Tire ordering analogy).


  ->Encapsulation: Hiding internal database/logic complexity from the outside world.

2. REST Architecture (The "Rules")

  ->Definition: Representational State Transfer.


  ->The Verbs (CRUD Mapping):

GET (Fetch) → SELECT

POST (Add) → INSERT

PUT (Replace/Update) → UPDATE

PATCH (Modify/Partial Update) → UPDATE (Specific fields)

DELETE (Remove) → DELETE


  ->Idempotency: Understanding which actions are "Safe" to repeat (like GET/PUT) and which are "Dangerous" (like POST).

3. State vs. Stateless

  ->Stateful: Like a "Bank Teller" who remembers you throughout a session.


  ->Stateless: Like a "Vending Machine." Every request must stand on its own and include all necessary information (Tokens, IDs).


  ->The Benefit: Makes apps like FoodieGo and CineXHub highly scalable and reliable.

4. Swagger (Documentation & Testing)

  ->Tooling: Using Swashbuckle to generate the UI.


  ->Interactive Testing: Using the "Try it out" feature to test C# code without a frontend.


  ->OpenAPI: The global standard that Swagger follows.

5. ASP.NET Core API Implementation

  ->ControllerBase: The lightweight foundation for API controllers (no HTML views).
  ->[ApiController]: The attribute that enables automatic validation and smart data binding.
  ->JSON: The universal language used for data exchange.
