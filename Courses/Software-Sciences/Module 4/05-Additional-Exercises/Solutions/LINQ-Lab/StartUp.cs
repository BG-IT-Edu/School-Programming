using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoftUni.Data;

namespace SoftUni
{
    public class StartUp
    {
        static void Main()
        {
            var context = new SoftUniContext();
            //string letter = Console.ReadLine();
            //Console.WriteLine(FindTownsStartingWith(context, letter));
            int empId = int.Parse(Console.ReadLine());
            Console.WriteLine(EmployeeWithProjects(context, empId));

        }

        public static string FindTownsStartingWith(SoftUniContext context, string letter)
        {
            var adresses = context.Addresses
                .Join(context.Towns,
                (a => a.TownId),
                (t => t.TownId),
                (a, t) => new
                {
                    Town = t.Name,
                    Address = a.AddressText
                }
                ).Where(x => x.Town.StartsWith(letter)).ToList();
            StringBuilder sb = new StringBuilder();
            foreach (var adress in adresses)
            {
                sb.AppendLine(adress.Town + " " + adress.Address);
            }

            return sb.ToString().Trim();
        }
        public static string EmployeeWithProjects(SoftUniContext context, int employeeId)
        {
            var employeeWithProjects = context
                .Employees
                .SelectMany(emp => emp.EmployeesProjects, (emp, proj) => new { emp, proj })
                .Where(x => x.emp.EmployeeId == employeeId)
                .Select(x =>
                new
                {
                    Employee = x.emp.FirstName,
                    Project = x.proj.Project.Name
                }).ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var empProj in employeeWithProjects)
            {
                sb.AppendLine($"{ empProj.Employee}: {empProj.Project}");
            }

            return sb.ToString().Trim();
        }

    }
}
