using System;

namespace Demo.Polymorphism
{
    // Parent/Base class
    public abstract class BankAccount
    {
        public string Type { get; set; }
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public Employee Employee { get; set; }

        public BankAccount(string type, string accountNumber)
        {
            Type = type;
            AccountNumber = accountNumber;
            Balance = 1000;
        }

        public void Credit(double amount)
        {
            // Example of the typical parameter value checking with if..else
            //if (amount > 0)
            //{
            //    Balance += amount;
            //}
            //else
            //{
            //    throw new InvalidOperationException("amount should be greater than zero.");
            //}

            // As a experienced developer this is how you should check parameter.
            // Try to avoid else case.
            if (amount <= 0)
            {
                throw new InvalidOperationException("amount should be greater than zero.");
            }

            Balance += amount;
        }

        #region 'Static Polymorphism (Overloading) (Compile Time)'
        public void Debit(double amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException("amount should be greater than zero.");
            }

            Balance -= amount;
        }

        public void Debit(double amount, double tax)
        {

        }
        #endregion

        #region 'This is the problem'
        public void DebitForSavingAccount(double amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException("amount should be greater than zero.");
            }

            Balance -= amount + (amount * 0.10);
        }

        public void DebitForCurrentAccount(double amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException("amount should be greater than zero.");
            }

            Balance -= amount + (amount * 0.15);
        }
        #endregion

        #region 'Dynamic Polymorphism (Overrriding) (Runtime)'
        public abstract void DebitAmount(double amount);
        #endregion
    }
}
