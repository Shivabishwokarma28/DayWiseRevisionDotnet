# DayWiseRevisionDotnet
Revision of code and better understanging

Day 14: 
1. ExecuteScalar:

  ->How it works: It ignores every row and column except for the very first cell of the result set (Row 1, Column 1).

  ->Return Type: It returns an object. You learned that you must type-cast it (e.g., (int)) to use it in C#.

  ->Common Use Cases:

SELECT COUNT(*) (Total records).

SELECT MAX(Salary) (Highest value).

SELECT StudentName WHERE ID = 5 (Single lookup).

2. Lambda Expressions: C# Shorthand
We explored the "Anonymous Function"

  ->syntax: input => logic. This allowed you to stop writing full, named methods for small tasks and start writing inline logic.

  ->Evolution: You saw how a 4-line method can become a 1-line expression.

  ->The Lambda Operator (=>): Read as "Goes to."

Types of Lambdas:

  ->Expression Lambdas: Single line, like s => s.Age > 18.

  ->Statement Lambdas: Multi-line inside { } braces.


3. Ternary Operator vs. Lambda
We clarified a common point of confusion. You learned that these are two different "shortcuts":

  ->Ternary (? :): A shorthand for if-else (picking a value).

  ->Lambda (=>): A shorthand for a method (defining a behavior).

4. Introduction to LINQ (Preview)
   
We hvae started seeing how Lambdas make LINQ (Language Integrated Query) possible. We have learned that we can filter lists using .Where() and sort them using .OrderBy() by passing a Lambda expression into those methods.

C#

// The power of Day 14 combined:

var topStudent = students.OrderByDescending(s => s.Grade).First();

5. Senior Developer Interview Prep
We covered critical "Senior" edge cases, such as:

  ->Null Handling: Why ExecuteScalar returns null for no rows but DBNull.Value for a SQL NULL.

  ->Closures: How Lambdas "capture" outside variables and the risks involved.

  ->Performance: Why ExecuteScalar is faster than ExecuteReader for counts (it avoids the overhead of a data stream).
