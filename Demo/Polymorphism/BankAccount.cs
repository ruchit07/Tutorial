using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Polymorphism
{
    public class BankAccount
    {
        public string Type { get; set; }
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public Employee Employee { get; set; }

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

        #region 'Static Polymorphism (Overloading)'
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

    }
}
