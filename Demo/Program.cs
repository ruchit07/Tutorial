using Demo.Polymorphism;
using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {   
            Employee employee = new Employee();
            employee.SaveEmployee("John", "Doe", 123456789);

            Employee employee1 = new Employee();
            employee1 = employee.GetEmployee();
            string userName = employee.GetUserName();

            SavingAccount savingAccount = new SavingAccount("saving", "123");
            CurrentAccount currentAccount = new CurrentAccount("current", "456");

            savingAccount.DebitAmount(10);
            currentAccount.DebitAmount(10);

            // Below is the problem
            // Current account method is available to saving account and vice-versa.
            //savingAccount.DebitForCurrentAccount(10);
            //currentAccount.DebitForSavingAccount(10);
        }
    }
}
