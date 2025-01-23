using AutoMapper;
using SoftUni.Data;
using SoftUni.Dto;
using SoftUni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUni.Controllers
{
    public class EmployeeController
    {
        private readonly SoftUniContext context;

        public EmployeeController(SoftUniContext context)
        {
            //Set the Context
            this.context = context;
        }

        public EmployeeDtoViewModel GetEmployeeInfo(int id)
        {
            //Initialize the mapper
            MapperConfiguration config = new MapperConfiguration(cfg =>
            cfg.CreateMap<Employee, EmployeeDtoViewModel>());

            //Using automapper
            Mapper mapper = new Mapper(config);

            Employee employee = context.Employees.FirstOrDefault(e => e.EmployeeId == id);
            EmployeeDtoViewModel dto = mapper.Map<EmployeeDtoViewModel>(employee);

            return dto;
        }
    }
}
