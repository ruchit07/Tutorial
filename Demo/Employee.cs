using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    // Public           Highest level access where it will be accessible throuout the application or it's dependent application
    // Private          This access modifier allows access within the region
    // Protected        Access in the inherited or child class
    // Internal         Access within the assembly i.e demo.dll
    public class Employee
    {
        // Variables
        private bool _saved;
        public string Username;

        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }

        private string _username;
        public string _UserName 
        { 
            get 
            {
                if (_username == null || _username == "") 
                {
                    return "No UserName Set";
                }

                return _username;
            } 
            set 
            {
                _username = value;
            } 
        }

        // Constructor
        // Static Constructor : Which will be called only once when the first instance of the class will be created.
        static Employee()
        {

        }

        // Public constructor
        public Employee()
        {

        }

        // Parameteraised constructor
        public Employee(string firstName)
        {
            FirstName = firstName;
        }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Employee(string firstName, string lastName, int phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }

        // Methods
        public void SaveEmployee(string firstName, string lastName, int phone)
        {   
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            // call database method to save employee
            // db.Employee.Save(this);
        }

        public Employee GetEmployee()
        {
            // Get all employees from database
            // db.Employee.Get();
            FirstName = "John";
            LastName = "Doe";
            Phone = 123456789;

            return this;
        }

        public string GetUserName()
        {
            string userNameWithConcatanation = FirstName + " " + LastName;
            string userNameWithInterpolation = $"{FirstName} {LastName}";
            string userNameWithStringJoin = string.Join(' ', FirstName, LastName);

            return userNameWithInterpolation;
        }
    }

    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string firstName)
            : base(firstName)
        {

        }
    }
}
