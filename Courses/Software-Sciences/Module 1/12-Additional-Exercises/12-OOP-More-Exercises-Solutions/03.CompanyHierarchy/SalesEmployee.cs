using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyHierarchy
{
    public class SalesEmployee : IEmployee
    {
        const decimal salaryDefault = 1000;
        public SalesEmployee(string firstName, string lastName, string department, decimal profits)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Department = department;
            this.Salary = salaryDefault;
            this.Profits = profits;
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public decimal Profits { get; set; }

        public decimal GetSalary()
        {
            return this.Profits * 0.1m + this.Salary;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} from {this.Department} has {this.Profits} profits.";
        }
    }
}
