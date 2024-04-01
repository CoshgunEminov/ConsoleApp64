using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp64
{
    internal class Employee
    {
        private string name;
        private string position;
        private decimal salary;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                name = value;
            }
        }

        public string Position
        {
            get { return position; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Position cannot be null or empty.");
                }
                position = value;
            }
        }

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative.");
                }
                salary = value;
            }
        }

        public Employee(string name, string position, decimal salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }

        public void IncreaseSalary(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Increase amount cannot be negative.");
            }
            Salary += amount;
        }

        public void ChangePosition(string newPosition)
        {
            Position = newPosition;
        }

        public void DisplayInformation()
        {
            Console.WriteLine($"Name: {Name}, Position: {Position}, Salary: {Salary}");
        }
    }
}
