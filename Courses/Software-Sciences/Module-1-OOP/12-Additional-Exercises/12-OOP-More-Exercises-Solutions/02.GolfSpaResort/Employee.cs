using System;
using System.Collections.Generic;
using System.Text;

namespace GolfSpaResort
{
    public class Employee : IPerson
    {
        public Employee(string firstName, string lastName, string department, int employeeId)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Department = department;
            this.EmployeeId = employeeId;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public int EmployeeId { get; set; }

        public string StartWorkingDay()
        {
            return $"{this.FirstName} {this.LastName} with id {this.EmployeeId} starts a new working day in the department {this.Department}.";
        }

    }
}
