# DayWiseRevisionDotnet
Revision of code and better understanging

Day 2

1. Methods & Functions
   --Method Signatures:
    Understanding return types (int, string, void) and access modifiers.
   --Arguments vs. Parameters:
   The difference between the "label" and the "actual value."
   --Named & Optional Parameters:
    How to make methods flexible and readable (e.g., decimal discount = 0).
   --Method Overloading:
   Having multiple methods with the same name but different "inputs" (The Payment System example).
2. Advanced Class Concepts
   We went deeper into how objects are born, how they live, and how they are cleaned up.
   --Constructors & Overloading:
    Creating objects in different ways (The Bank Account with $0$ vs. initial deposit).
   --Constructor Chaining:
    Using : this() to keep code "DRY" and prevent duplication.
   --Destructors (Finalizers):
   Understanding that the Garbage Collector (GC) calls these non-deterministically.
   --IDisposable & Dispose:
   The professional way to clean up "unmanaged" resources (Files/Databases) immediately using the using statement.
3. Encapsulation (The "Guardians")
   We learned how to protect our data from "cheating" or accidental corruption.
   --Access Modifiers:
   The difference between public, private, protected, and internal.
   --Properties: Using get and private set to act as a gatekeeper for our fields (The ATM analogy).
4. Object Lifecycle & MemoryA key "Senior" topic regarding where your data actually sits.
   --Garbage Collection (GC): How .NET manages memory automatically.
   --Managed vs. Unmanaged Resources: Why some things need manual cleanup (Dispose) and others don't.
