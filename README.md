# DayWiseRevisionDotnet
Revision of code and better understanging

Day 3: 
1. Arrays (Fixed Size)
An array is a collection of variables of the same type stored in a contiguous block of memory.

--Single-Dimensional: int[] numbers = new int[5];

--Multidimensional (Rectangular): int[,] matrix = new int[3, 3]; (Like a spreadsheet with rows and columns).

--Jagged Array: An "array of arrays" where each row can have a different length.

--Array Class Methods (System.Linq)
Using System.Linq allows you to perform "Instant Math" on any array:

a. Max(): Finds the largest value.

b. Min(): Finds the smallest value.

c. Sum(): Adds all values together.

2. Non-Generic Collections:
   --The ArrayList
        The ArrayList is a dynamic array. It lives in the System.Collections namespace.

         How it works: It can grow or shrink in size automatically.

       The Object Factor: It stores everything as an object, meaning you can mix types (integers, strings, and booleans in one list).

--Essential ArrayList Methods & Properties:
   ->Add(value): Places the item at the very end.

   ->Insert(index, value): Squeezes an item into a specific position.

   ->Remove(value): Finds and deletes the first occurrence of that value.

  ->RemoveAt(index): Deletes the item at that specific "chair" number.

  ->Count vs. Capacity:

  Count = How many items are actually inside.

  Capacity = How many items it can hold before it has to resize itself.

3. Git & GitHub (The Professional Workflow)
You can’t work in a modern company without these. Here is how to explain them in an interview:

Definitions:
Git: A Version Control System (Software on your computer). It takes "snapshots" of your code so you can go back in time if you break something.

GitHub: A Cloud Platform (Website). It hosts your Git repositories so you can share code with your team.

Real-Life Usage:
  ->Commit: A "Save Point" with a message describing what you changed.

  ->Push: Sending your local "Save Points" to GitHub.

  ->Pull: Grabbing the latest changes from your teammates on GitHub.

  ->Branching: Creating a separate "copy" of the code to work on a new feature without affecting the main project.

Why use it? (Interview Aspect)
--Safety: If your computer dies, your code is safe on the server.

--Collaboration: It prevents two developers from overwriting each other's code.

Experimental: You can try a crazy idea on a new branch and just delete it if it doesn't work.
