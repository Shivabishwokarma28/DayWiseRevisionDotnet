# DayWiseRevisionDotnet
Revision of code and better understanging

Day 9:
1. Professional Exception Handling
The "Jump" Logic: How the CPU skips the rest of the try block as soon as an alarm is fired (throw).

  ->Custom Exceptions: Creating specific classes like InsufficientFundsException to handle business rules that aren't "math errors" but are "illegal actions."

  ->The Cleanup Crew (finally): Ensuring the "vault is locked" (resources are released) even if the alarm goes off.

  ->Exception vs. Error: Distinguishing between "Missing Milk" (fixable logic) and "No Electricity" (unrecoverable system failure).

2. File Handling & The "Using" Rule
   
  ->Persistence: Moving data from volatile RAM to a permanent Hard Drive.

  ->StreamReader/Writer: The professional way to read and write data line-by-line without crashing the memory.

  ->IDisposable & using(): The "Return the Library Book" rule. You learned that using automatically calls .Dispose() to unlock files so they don't get stuck in "File                            in Use" mode.

3. Mini Project 1: Inventory Tracker (The Domain)
   
  ->Inventory Categories: You researched the three stages of production:

  ->Raw Materials: Unprocessed items.

  ->Work in Progress (WIP): Items currently being built.

  ->Finished Goods: Ready for the customer.

  ->CRUD Logic: You now know how to build a menu to Create, Read, Update, and Delete these items from a .txt file.
