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
        }
    }
}
