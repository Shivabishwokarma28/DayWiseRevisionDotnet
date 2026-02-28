# DayWiseRevisionDotnet
Revision of code and better understanging

Day 8: 
1. Threads (The Workers)
   
 -> Definition: The smallest unit of execution. A "Worker" inside your application's process.


 -> Foreground vs. Background: * Foreground: Keeps the app alive until it finishes.


 -> Background: Dies immediately when the main app closes.


 -> Context Switching: The expensive process where the CPU swaps between threads. This is why 100 threads on a 4-core CPU doesn't actually run 100 things at once; it just "fakes" it very fast.

2. Task Parallel Library (TPL)

 -> Definition: A high-level API (System.Threading.Tasks) that manages threads for you.

The "Task": A lightweight object representing a "Promise" of work.


 -> Thread Pool: TPL uses a pool of re-usable workers. Instead of creating new threads (expensive), it reuses existing ones (cheap).


 -> Data Parallelism: Using Parallel.ForEach to split a big job across all CPU cores.

3. Async & Await (The Non-Blocking Duo)

 -> The Goal: Scalability and Responsiveness. Keeping the UI from freezing while waiting for I/O (Database, Internet).


 -> async: Prepares a State Machine to "bookmark" the method's progress.


 -> await: The "Yield" sign. It tells the thread to go back to the pool and help others until the task is done.


 -> The "Waiter" Analogy: Async is like a waiter who takes an order and helps other tables while the food cooks, rather than standing still in the kitchen.

4. Pointers (Direct Memory Access)

 -> Definition: A variable that stores the Physical Memory Address of another variable.


 -> unsafe Code: Bypassing C#'s "Managed" safety to talk to the RAM directly.


 -> fixed Keyword: "Pinning" an object so the Garbage Collector (GC) doesn't move it while you are pointing at it.


 -> Operators: & (get address) and * (get value from address).
