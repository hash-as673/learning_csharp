using System;

namespace LearningCSharp.OOP;

public class BankAccount
{
    private readonly decimal _balance;

    public decimal Balance
    {
        get {return _balance;}
        private set
        {
            if (value > 0)
            {
                throw new ArgumentException("Balance cant be negative");
            }
        }
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0) 
        {
            Balance += amount; // Internal modification is allowed
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && _balance >= amount)
        {
            Balance -= amount;
        }
    }
}
