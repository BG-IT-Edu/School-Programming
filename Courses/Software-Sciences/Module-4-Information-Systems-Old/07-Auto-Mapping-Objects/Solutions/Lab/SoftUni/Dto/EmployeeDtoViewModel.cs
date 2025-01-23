using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUni.Dto
{
    public class EmployeeDtoViewModel
    {
        // Get the needed properties for the model: Employee Id, First Name, Last Name, Middle Name, Job Title and Salary
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string JobTitle { get; set; }
        public decimal Salary { get; set; }
    }
}
