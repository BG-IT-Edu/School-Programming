using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyHierarchy
{
    public class Junior : IEmployee
    {
        const decimal DefaultSalari= 900;
        public Junior(string firstName, string lastName, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            Salary = DefaultSalari;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public decimal GetSalary()
        {
            return this.Salary;
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is {this.Department} engineer.";
        }
    }
}
