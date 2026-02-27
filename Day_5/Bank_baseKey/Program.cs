using System;

namespace InheritanceDemo
{
    // Parent Class (Base)
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string OwnerName { get; set; }

        // The parent constructor defines the "rules" (accNo comes first, then ownerName)
        public BankAccount(string accNo, string ownerName)
        {
            this.AccountNumber = accNo;
            this.OwnerName = ownerName;
            Console.WriteLine("--- Base Constructor Running ---");
            Console.WriteLine($"Stored: {this.AccountNumber} for {this.OwnerName}");
        }

        public virtual void Display()
        {
            Console.WriteLine($"\nAccount Info: {AccountNumber} | Owner: {OwnerName}");
        }
    }

    // Child Class (Derived)
    public class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }

        // Child receives parameters in a different order: (name, acc, rate)
        public SavingsAccount(string name, string acc, double rate) 
            : base(acc, name) // MAPPING: We send 'acc' to 'accNo' and 'name' to 'ownerName'
        {
            this.InterestRate = rate;
            Console.WriteLine("--- Child Constructor Running ---");
            Console.WriteLine($"Stored Interest Rate: {this.InterestRate}%");
        }

        public override void Display()
        {
            base.Display(); // Calls the parent logic to print Account and Owner
            Console.WriteLine($"Interest Rate applied: {InterestRate}%");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Note the order here: "John Doe" (name), "SAV-101" (acc), 4.5 (rate)
            SavingsAccount mySavings = new SavingsAccount("Minato Namikaze", "SAV-101", 4.5);

            mySavings.Display();
            
            Console.ReadKey();
        }
    }
}