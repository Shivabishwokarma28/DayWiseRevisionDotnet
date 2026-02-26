using System;

namespace BankingSystem
{
    public class BankAccount
    {
        // 1. Private Fields (Data Hiding)
        private string _owner;
        private decimal _balance;

        // 2. Public Properties (Encapsulation)
        public string Owner 
        { 
            get { return _owner; } 
            set { _owner = value; } 
        }

        public decimal Balance
        {
            get { return _balance; }
            // The setter is private so the balance cannot be changed 
            // from Program.cs directly (e.g., acc.Balance = 1000000; will fail)
            private set { _balance = value; }
        }

        // 3. Constructors (Object Initialization)
        
        // Scenario A: Initial Deposit provided
        public BankAccount(string name, decimal initialDeposit)
        {
            Owner = name;
            // We use the Deposit method logic instead of setting the field directly
            // to ensure the "amount > 0" validation is checked.
            Deposit(initialDeposit);
            Console.WriteLine($"Account for {Owner} created with ${initialDeposit}.");
        }

        // Scenario B: Zero balance account
        // We use ': this' to chain to the constructor above, passing 0 as the deposit
        public BankAccount(string name) : this(name, 0)
        {
            // The logic above handles the assignment!
        }

        // 4. Methods (Behavior)
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: ${amount}. New Balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew: ${amount}. Remaining: ${Balance}");
            }
            else
            {
                Console.WriteLine("Withdrawal failed: Insufficient funds or invalid amount.");
            }
        }
    }

    // Execution Class
    class Program
    {
        static void Main(string[] args)
        {
            // Using Constructor B (Zero balance)
            BankAccount acc1 = new BankAccount("Suman");
            acc1.Deposit(500);

            // Using Constructor A (Initial Deposit)
            BankAccount acc2 = new BankAccount("Alice", 1000);
            acc2.Withdraw(200);
            
            // Try to cheat:
            // acc2.Balance = 999999; // Error: Property 'Balance' is read-only from here.
        }
    }
}