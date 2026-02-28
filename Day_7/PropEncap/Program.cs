using System;

namespace Day7Properties
{
    public class BankAccount
    {
        // 1. FIELD (The Private Vault)
        // This is hidden on the Heap. No one can touch this directly.
        private decimal _balance; 

        // 2. PROPERTY (The Public Security Guard)
        public decimal Balance 
        {
            // This runs when you try to LOOK at the balance
            get 
            { 
                return _balance; 
            } 
            
            // This runs when you try to CHANGE the balance
            set 
            {
                if (value < 0) 
                {
                    Console.WriteLine(">>> REJECTED: You cannot have a negative balance!");
                    // We don't update _balance, so the old value stays safe.
                }
                else 
                {
                    _balance = value; 
                    Console.WriteLine($">>> SUCCESS: Balance updated to {value:C}");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();

            // TEST 1: Setting a valid positive value
            Console.WriteLine("Attempting to deposit $500...");
            myAccount.Balance = 500; // Calls the 'set' with value = 500
            
            // TEST 2: Reading the value
            Console.WriteLine($"Current Balance is: {myAccount.Balance}"); // Calls the 'get'

            Console.WriteLine("--------------------------------------");

            // TEST 3: Attempting to set an INVALID negative value
            Console.WriteLine("Attempting to set balance to -$150...");
            myAccount.Balance = -150; // Calls the 'set' with value = -150

            // TEST 4: Verifying the data was NOT corrupted
            Console.WriteLine($"Final Balance after failed hack: {myAccount.Balance}");

            // Wait for user input before closing
            Console.ReadKey();
        }
    }
}