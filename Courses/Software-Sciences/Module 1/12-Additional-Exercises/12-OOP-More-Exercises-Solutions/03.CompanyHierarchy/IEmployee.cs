using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyHierarchy
{
    public interface IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public decimal GetSalary();

    }
}
