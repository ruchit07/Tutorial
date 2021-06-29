using System;

namespace Demo.Polymorphism
{
    // Child/Derived Class
    public class CurrentAccount : BankAccount
    {
        public CurrentAccount(string type, string accountNumber) : base(type, accountNumber)
        {

        }

        #region 'Override of Debit Method'
        public override void DebitAmount(double amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException("amount should be greater than zero.");
            }

            Balance -= amount + (amount * 0.15);
        }
        #endregion
    }
}
