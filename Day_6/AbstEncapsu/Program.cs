using System;

public abstract class AtmTransaction
{
    // ENCAPSULATION: The user cannot change the balance directly.
    // It is protected so only the Bank/Transactions can touch it.
    protected decimal _accountBalance = 5000.00m; 

    // SHARED LOGIC: Every transaction must check the PIN first.
    // This is hidden logic (Encapsulation).
    private bool IsPinValid() 
    {
        Console.WriteLine("System: Validating PIN with secure server...");
        return true; 
    }

    // THE WORKFLOW: This is the "Public Screen" button.
    public void Execute()
    {
        if (IsPinValid())
        {
            PerformTransaction(); // Call the specific child logic
            Console.WriteLine($"Transaction Complete. New Balance: {_accountBalance:C}");
        }
    }

    // ABSTRACTION: "Withdraw" and "Deposit" are different.
    // The parent says: "I don't know HOW to change the money, you decide."
    protected abstract void PerformTransaction();
}

public class Withdraw : AtmTransaction
{
    protected override void PerformTransaction()
    {
        Console.WriteLine("Withdrawal: Deducting $100 from balance...");
        _accountBalance -= 100; // Specific logic
    }
}

public class Deposit : AtmTransaction
{
    protected override void PerformTransaction()
    {
        Console.WriteLine("Deposit: Adding $500 to balance...");
        _accountBalance += 500; // Specific logic
    }
}