# DayWiseRevisionDotnet
Revision of code and better understanging

Day 7: 
1. Properties (The Smart Gates)
   
 ->Definition: A member that provides a flexible mechanism to read, write, or compute the value of a private field.

 ->Getters & Setters: The get (Read) and set (Write) accessors.

 ->The value Keyword: The built-in variable used in the set block to represent incoming data.Encapsulation: Using properties to validate data (e.g., preventing a        negative bank balance).

 ->Auto-Implemented Properties: The shortcut public int ID { get; set; } where the compiler creates the hidden field for you.

2. Indexers (Object Arrays)
   
    ->Definition: A property that allows an object to be indexed like an array using square brackets [].
   
    ->The this Keyword: The unique syntax used to define an indexer.
   
    ->The Analogy: If the Class is a Book, the Indexer is the Page Number.

    ->Advantage: Provides an intuitive way to access internal collections while keeping the raw data protected.

 3. Delegates (Method Variables)
       ->Definition: A type-safe Function Pointer. It is a variable that holds a reference to a method instead of a value.

       ->Mechanism: The three steps are Define (delegate type), Point (instantiate), and Invoke (call).
      
       ->Multicasting: The ability of one delegate to hold and run multiple methods using the += operator.

4. Stack vs. Heap (Memory Management)
    ->Stack: Used for Value Types (int, bool) and Pointers. It is small, fast, and follows LIFO (Last-In-First-Out).

    ->Heap: Used for Reference Types (class, string, object). It is large and managed by the Garbage Collector (GC).

    ->The Difference: Stack memory is self-cleaning when a method ends; Heap memory stays until the GC clears it.

5. Bug and DebugBug
    ->Types:
   1.  Syntax: Grammar mistakes.
   2.  Runtime: Crashes (e.g., Division by zero).
   3.  Logic: Code runs but gives the wrong result ($2+2=5$).
      
-> Debugging Tools:
* Breakpoint (F9): Pausing the code at a specific line.Watch Window: Monitoring variable values in real-time.
* Stepping (F10/F11): Moving through code line-by-line.

  📌 Reminder for Next SessionTopic:
  Event Handling (The Publisher-Subscriber model).
  Goal: Learn how to use the event keyword to make Delegates safer for notifications.
