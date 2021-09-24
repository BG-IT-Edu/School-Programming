using AutoMapper;
using SoftUni.Controllers;
using SoftUni.Data;
using SoftUni.Dto;
using SoftUni.Models;
using System;

namespace SoftUni
{
    public class StartUp
    {
        static void Main()
        {
            var context = new SoftUniContext();

            Console.WriteLine("Write the id of an Employee to get his information.");

            var employeeInfoRequest = int.Parse(Console.ReadLine());

            EmployeeController controler = new EmployeeController(context);

            var employeeInfoResult = controler.GetEmployeeInfo(employeeInfoRequest);

            Console.WriteLine(employeeInfoResult.EmployeeId.ToString());
            Console.WriteLine(employeeInfoResult.FirstName.ToString());
            Console.WriteLine(employeeInfoResult.LastName.ToString());
            Console.WriteLine(employeeInfoResult.MiddleName.ToString());
            Console.WriteLine(employeeInfoResult.JobTitle.ToString());
            Console.WriteLine(employeeInfoResult.Salary.ToString());

            //New Folders: Dto, Controllers
        }


    }
}
