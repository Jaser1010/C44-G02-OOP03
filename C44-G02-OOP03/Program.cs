using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C44_G02_OOP03
{
    #region Question 1: Employee Class and Supporting Enum

    // Defines the security privilege levels for an employee, as required by Question 1.
    public enum SecurityPrivileges
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    // Represents an employee in the company, as required by Question 1.
    public class Employee
    {
        // Private backing fields for the properties.
        private int _id;
        private string _name;
        private SecurityPrivileges _securityLevel;
        private decimal _salary;
        private HireDate _hireDate;
        private char _gender;

        // Public properties to provide controlled access to the private fields.

        public int ID
        {
            get { return _id; }
            private set { _id = value; } // ID is read-only after creation.
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public SecurityPrivileges SecurityLevel
        {
            get { return _securityLevel; }
            set { _securityLevel = value; }
        }

        public decimal Salary
        {
            get { return _salary; }
            set
            {
                // Ensures the salary cannot be a negative value.
                if (value < 0)
                    Console.WriteLine("Error: Salary cannot be negative.");
                else
                    _salary = value;
            }
        }

        public HireDate HireDate
        {
            get { return _hireDate; }
            set { _hireDate = value; }
        }

        public char Gender
        {
            get { return _gender; }
            set
            {
                // Restricts the Gender field to 'M' or 'F'.
                char upperValue = char.ToUpper(value);
                if (upperValue == 'M' || upperValue == 'F')
                    _gender = upperValue;
                else
                    Console.WriteLine("Error: Gender must be 'M' or 'F'.");
            }
        }

        // Constructor to initialize a new Employee object.
        public Employee(int id, string name, SecurityPrivileges securityLevel, decimal salary, HireDate hireDate, char gender)
        {
            this.ID = id;
            this.Name = name;
            this.SecurityLevel = securityLevel;
            this.Salary = salary;
            this.HireDate = hireDate;
            this.Gender = gender;
        }

        // Overrides the default ToString method to provide a comprehensive, formatted string
        // representing the employee's data. Salary is formatted as currency.
        public override string ToString()
        {
            string formattedString = String.Format(
                "Employee Details:\n" +
                "  ID: {0}\n" +
                "  Name: {1}\n" +
                "  Gender: {2}\n" +
                "  Security Level: {3}\n" +
                "  Salary: {4:C}\n" + // C format specifier for currency
                "  Hire Date: {5}",
                ID, Name, Gender, SecurityLevel, Salary, HireDate.ToString()
            );
            return formattedString;
        }
    }

    #endregion

    #region Question 2: HireDate Struct

    // Represents the hiring date for an employee, as required by Question 2.
    public struct HireDate
    {
        // Public fields for Day, Month, and Year.
        public int Day;
        public int Month;
        public int Year;

        // Constructor to initialize the HireDate.
        public HireDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        // Overrides the default ToString method to provide a formatted date string.
        public override string ToString()
        {
            return $"{Day:D2}-{Month:D2}-{Year}";
        }
    }

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 & 2 Demonstration
            /*
            
            // Create a single employee to demonstrate the functionality of the classes and validation.
            Employee testEmployee = new Employee(100, "Test User", SecurityPrivileges.Guest, 50000m, new HireDate(1, 1, 2023), 'M');
            Console.WriteLine("Initial Employee Data:");
            Console.WriteLine(testEmployee);
            
            Console.WriteLine("\n--- Testing Validation Logic ---");
            Console.WriteLine("Attempting to set an invalid gender...");
            testEmployee.Gender = 'Z'; // This will print an error message.
            Console.WriteLine($"Current Gender: {testEmployee.Gender}"); // Gender remains 'M'

            Console.WriteLine("\nAttempting to set a negative salary...");
            testEmployee.Salary = -1000; // This will print an error message.
            Console.WriteLine($"Current Salary: {testEmployee.Salary:C}"); // Salary remains 50000
            */
            #endregion

            #region Question 3 Demonstration
            /*

            // 1. Create an array of Employees with size three.
            Employee[] empArr = new Employee[3];

            // 2. Instantiate three employees with different roles as specified.
            empArr[0] = new Employee(101, "Ahmed Ali", SecurityPrivileges.DBA, 75000m, new HireDate(15, 5, 2020), 'M');
            empArr[1] = new Employee(102, "Sara Said", SecurityPrivileges.Guest, 30000m, new HireDate(20, 8, 2022), 'F');
            empArr[2] = new Employee(103, "Mona Mohamed", SecurityPrivileges.Developer, 60000m, new HireDate(10, 1, 2021), 'F');
            
            Console.WriteLine("\n--- Displaying Employee Details from Array ---\n");

            // 3. Loop through the array and display the details of each employee.
            foreach (var employee in empArr)
            {
                Console.WriteLine(employee);
            }
            */
            #endregion
        }
    }
}