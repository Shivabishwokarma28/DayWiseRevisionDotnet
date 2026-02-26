# DayWiseRevisionDotnet
Revision of code and better understanging

Day 4: 
Generics and Type-Safe Collections
1. Introduction to Generics
   --Key Benefits:Type Safety: Errors are caught at Compile-time rather than crashing at runtime.
   --Performance: Eliminates the need for Boxing and Unboxing, making the code faster.
   --Reusability: Write the logic once and use it for any data type.
2. Generic Methods and Classes
   --Generic Method
   A single method that can accept any type of parameter.

   
 public void ShowData<T>(T data) 
{
    Console.WriteLine($"Stored Value: {data}");
}


--Generic Class
A class that acts as a template for data.

public class Container<T> 
{
    public T Value { get; set; }
}

3. Generic Collections
   Modern .NET development uses the System.Collections.Generic namespace.
 A. List<T> (Dynamic Array)Logic:
       A type-safe version of ArrayList.
     ->Usage: Used when you need a list that can grow and allow access via an index.
     ->Methods: Add(), Remove(), Sort(), Insert().
B. Stack<T> (LIFO)
   ->Logic: Last-In, First-Out. The last item added is the first one removed.
   ->Real-World Scenario: "Undo" button logic or browser history.
   ->Methods: Push() (Add), Pop() (Remove/Return), Peek() (View top).
C. Queue<T> (FIFO)
->Logic: First-In, First-Out. The first item added is the first one removed.
->Real-World Scenario: Printer jobs or customer service ticket lines.
->Methods: Enqueue() (Add to end), Dequeue() (Remove from front), Peek() (View front).
4. Interview
   ->Quick-ReferenceFeature Non-Generic (ArrayList)Generic (List<T>)Type SafetyNo (Uses object)Yes (Uses <T>)
   ->PerformanceSlower (Boxing/Unboxing)Faster (Native Types)Error CheckingRuntime (Risk of Crash)Compile-time (Safe)
