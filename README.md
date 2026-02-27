# DayWiseRevisionDotnet
Revision of code and better understanging

Day 6:
1. Abstract Classes
   (The "Is-A" Blueprint)An abstract class is a "half-finished" class used as a base for others.
 ->Key Idea: It defines a common identity. A PdfDocument is a Document.
 ->Abstract Methods: No body; forces the child to provide implementation using override.
 ->Concrete Methods: Has logic; provides shared behavior (like logging or database connections) to all children.
  ->Constraint: Cannot be instantiated (new keyword won't work).

2. Interfaces (The "Can-Do" Contract)
   An interface is a strict set of rules that a class must follow.
  ->Key Idea: It defines an ability. A User class is not a Printer, but it can implement IPrintable.
  ->No State: Cannot have fields (variables) or constructors.
  ->Multiple Inheritance: A class can implement many interfaces (unlike abstract classes).
  ->Naming: Always starts with "I" (e.g., ISerializable).

3. Encapsulation in ArchitectureUsing access modifiers inside your abstract classes to protect data.
  ->Private/Protected: Hiding the "guts" (like the ATM's vault logic) while exposing the "buttons" (the public methods).
  ->Rule of Thumb: "Hide the data, expose the behavior."

4. Generics vs. Non-Generics (Boxing & Unboxing)
   This is the performance-critical part of C#.
  ->Boxing: Converting a Value Type (Stack) $\rightarrow$ Object/Reference Type (Heap).
  ->Unboxing: Converting the Object back $\rightarrow$ Value Type.The Winner: Generics (List<T>).
   They avoid this expensive process entirely, making your code faster and preventing runtime crashes (Type Safety).
   ->Comparison
   Summary
Feature           Abstract Class                                                      Interface
Relationship      "Is-A"                                                               "Can-Do"
Logic             Can have shared code                                                No code (signatures only)
Multiple?           No (Single inheritance)                                        Yes (Multiple implementation)VariablesYesNo
