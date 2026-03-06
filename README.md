# DayWiseRevisionDotnet
Revision of code and better understanging

Day 12: 

1. Database Automation (Smart Logic)
     ->Triggers: You learned how to set up "Auto-Pilots" that fire on INSERT, UPDATE, or DELETE. Essential for Auditing (tracking changes) and Data Safety                             (archiving deleted records).

  ->Functions (UDFs): You mastered the "Calculators" of the DB. Unlike Stored Procedures, these are Read-Only and can be used directly inside a SELECT statement to                        perform math or formatting.

2. The Art of Normalization (1NF, 2NF, 3NF)
   
You learned how to "Clean the Room" by splitting one big, messy table into smaller, efficient ones.

  ->1NF (Atomic): Every cell has one value; every table has a Primary Key.

  ->2NF (Partial Dependency): No "half-links." In tables with Composite Keys, every column must depend on the entire key.

  ->3NF (Transitive Dependency): The "Nothing But the Key" rule. No non-key column can depend on another non-key column (like City depending on ZipCode).

3. Relationships & Keys (The Connectors)
   
  ->Primary Key (PK): The unique "Anchor" for every row.

  ->Foreign Key (FK): The "Bridge" that points to a PK in another table, ensuring Referential Integrity.

  ->Junction Tables: The secret to handling Many-to-Many relationships (like Students taking multiple Classes).


4. Advanced Structural Changes (DDL)
   
  ->ALTER TABLE: How to evolve your database structure (adding columns or changing data types) without losing the data already inside.

  ->DROP TABLE: The "Nuclear Option"—complete destruction of a table and its data.

