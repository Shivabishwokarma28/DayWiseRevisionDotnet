# DayWiseRevisionDotnet
Revision of code and better understanging

Day 13: 
1. The ADO.NET Architecture
I have learned that ADO.NET isn't just one tool, but a collection of classes designed to handle Connected and Disconnected data.

  ->The Data Provider (Connected): 
  
  **SqlConnection: The "Pipe" that stays open while you talk to the server.
  **SqlCommand: The "Instruction" containing your SQL string and parameters.
  **SqlDataReader: The "Firehose" that streams data quickly and in one direction (Read-Only).
  **SqlDataAdapter: The "Bridge" that pulls data into a local cache.

  ->The DataSet (Disconnected):
  An in-memory "Mini-DB" that holds tables and rows even after the connection to the server is closed.
  
  
2. Connection Management & Security
This was the most critical "Senior" lesson of the day: Resources and Safety.

  ->The using Statement: We learned to wrap our connections in using blocks. This ensures the connection is closed and returned to the "Connection Pool" automatically, even if the code crashes.
  
  ->Connection Strings: Understanding how to tell the app where the database is, using Data Source, Initial Catalog, and Security settings.
  
  ->SQL Injection Prevention: We stopped using string concatenation (e.g., "...WHERE ID = " + id) and started using SqlParameters to shield our database from hackers.
  
  3. Command Execution Methods
We identified which method to call based on what we need the database to do:

Method                                     Best For                       Returns      

ExecuteNonQuery                            INSERT,UPDATE, DELETE                 An int (Rows affected)
ExecuteReader                               SELECT(Lists/Multiple rows)          A SqlDataReader
ExecuteScalar                               COUNT, SUM, MAX                    A single object (First col/First row)


4. CRUD Operations in C#
   We have implemented the full lifecycle of data management:

  ->Create: Inserting new student records.
  
  ->Read: Looping through records using while(reader.Read()).
  
  ->Update: Changing specific data points (like an Email) using a Primary Key.
  
  ->Delete: Safely removing records while maintaining referential integrity.
  
  
  
  5. ADO.NET vs. Entity Framework (EF) Core
     We discussed why we still learn the "old way" (ADO.NET) in a world of "new ways" (EF Core):

  ->Performance: ADO.NET is faster for bulk inserts and heavy reports.
  
  ->Control: You have 100% control over the raw SQL sent to the server.
  
  ->Under the Hood: EF Core actually uses ADO.NET internally!
