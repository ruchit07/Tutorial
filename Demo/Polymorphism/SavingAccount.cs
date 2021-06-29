using System;

namespace Demo.Polymorphism
{
    // Child/Derived class of BankAccount
    public class SavingAccount : BankAccount
    {
        public SavingAccount(string type, string accountNumber) : base(type, accountNumber)
        {

        }

        #region 'Override of Debit Method'
        public override void DebitAmount(double amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException("amount should be greater than zero.");
            }

            Balance -= amount + (amount * 0.10);
        }
        #endregion
    }
}
