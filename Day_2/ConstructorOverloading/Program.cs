using System;

namespace BankApplication
{
    public class BankAccount
    {
        // FIELDS (Encapsulated - hidden from outside)
        private string _owner;
        private decimal _balance;

        // PROPERTIES (Controlled access)
        public string Owner 
        { 
            get { return _owner; } 
            set { _owner = value; } 
        }

        public decimal Balance 
        { 
            get { return _balance; } 
            // Private set means only the methods inside this class can change the money
            private set { _balance = value; } 
        }

        // CONSTRUCTOR 1: Starting with zero balance
        // We use "this" to chain to the second constructor to avoid repeating code (DRY)
        public BankAccount(string name) : this(name, 0)
        {
            Console.WriteLine($"Account created for {Owner} with 0 balance.");
        }

        // CONSTRUCTOR 2: Starting with a deposit
        public BankAccount(string name, decimal initialDeposit)
        {
            Owner = name;
            // Use the Deposit method even in the constructor to ensure logic is applied
            Deposit(initialDeposit); 
        }

        // METHOD: Behavior to change the state safely
        public void Deposit(decimal amount)
        {
            if (amount >= 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: ${amount}. Current Balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Error: Deposit amount must be positive.");
            }
        }

        // METHOD: Logic-heavy behavior
        public void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew: ${amount}. Remaining: ${Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds for this withdrawal.");
            }
        }
    }

    // THE EXECUTION
    class Program
    {
        static void Main(string[] args)
        {
            // Create account using Constructor 1
            BankAccount acc1 = new BankAccount("Suman");
            acc1.Deposit(500);

            Console.WriteLine("-------------------------");

            // Create account using Constructor 2
            BankAccount acc2 = new BankAccount("Alice", 1000);
            acc2.Withdraw(200);

            // Attempting to cheat:
            // acc2.Balance = 5000000; // ERROR: This won't compile because Balance set is private!
        }
    }
}