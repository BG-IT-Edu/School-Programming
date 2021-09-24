using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyHierarchy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<IEmployee> employees = new List<IEmployee>();

            while (input != "End")
            {
                string[] employeeInfo = input.Split();
                string firstName = employeeInfo[0];
                string lastName = employeeInfo[1];
                string department = employeeInfo[2];

                if (department == "Sales")
                {
                    decimal profit = decimal.Parse(employeeInfo[3]);
                    SalesEmployee salesEmployee = new SalesEmployee(firstName, lastName, department, profit);
                    employees.Add(salesEmployee);
                }
                else if (department == "Engineering")
                {
                    int yearsServed = int.Parse(employeeInfo[3]);
                    Engineer engineer = new Engineer(firstName, lastName, department, yearsServed);
                    employees.Add(engineer);
                }
                else if (department == "Junior")
                {
                    Junior junior = new Junior(firstName, lastName, department);
                    employees.Add(junior);
                }

                input = Console.ReadLine();
            }

            StringBuilder sb = new StringBuilder();

            foreach (var employee in employees)
            {
                sb.AppendLine(employee.ToString());
                sb.AppendLine($"Receives a salary {employee.GetSalary()}.");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
