using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyHierarchy
{
    public class Engineer : IEmployee
    {
        const decimal defaultSalary = 1300;
        public Engineer(string firstName, string lastName, string department, int yearsService)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            Salary = defaultSalary;
            YearsService = yearsService;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public int YearsService { get; set; }

        public decimal GetSalary()
        {
            return this.Salary + this.YearsService * 90;
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} from {this.Department} has {this.YearsService} years of service.";
        }
    }
}
