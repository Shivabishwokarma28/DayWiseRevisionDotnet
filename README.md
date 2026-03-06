# DayWiseRevisionDotnet
Revision of code and better understanging

Day 11: 
1. Advanced DML (Data Manipulation)
   
  ->The Filtered SELECT: Moving beyond SELECT * to specific columns and using WHERE, ORDER BY, and GROUP BY to find exactly what the user needs.


  ->The "Dangerous" Duo (UPDATE & DELETE): Understanding the critical importance of the WHERE clause to avoid wiping out an entire database.


  ->Soft Deletes: The industry secret of using a bit or boolean flag (like IsActive) instead of physically deleting records to preserve history.

2. Relational Joins (The Bridge)

  ->INNER JOIN: The "Match Maker"—only showing rows that exist in both tables (e.g., Products that have a Category).


  ->LEFT JOIN: The "Priority List"—keeping everything from the main table, even if the second table has no match (e.g., All Suppliers, even those with 0 products).


  ->RIGHT/FULL JOIN: Understanding how to handle data "orphans" on either side of a relationship.


  ->ON Clause: Identifying the "ID Bridge" between Primary Keys and Foreign Keys.

3. Performance & Optimization

  ->The Cartesian Product: Learning the "Math Trap" where mismatched joins cause rows to multiply into millions, freezing the app.


  ->Indexing Foreign Keys: The #1 rule for making Joins fast. You learned that an Index acts like a book's index, allowing the DB to skip the "Linear Scan" and jump      to the data.


  ->Execution Plans: Using tools in SSMS to "X-ray" a query and find out why it’s running slowly.

4. Stored Procedures (The Professional Script)

  ->Pre-Compilation: Why SPs are faster than raw SQL strings sent from C#.


  ->Security (SQL Injection): Using Parameters (@Value) to ensure a hacker can't inject malicious code into your database.


  ->Maintenance: The ability to fix a bug in your SQL logic directly in the database without having to re-deploy your entire C# application.
