namespace FastFood.Core.Controllers
{
    using System;
    using System.Linq;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Data;
    using FastFood.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using ViewModels.Employees;

    public class EmployeesController : Controller
    {
        private readonly FastFoodContext context;
        private readonly IMapper mapper;

        public EmployeesController(FastFoodContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IActionResult Register()
        {
            var models = this.context.Positions
                .ProjectTo<RegisterEmployeeViewModel>(mapper.ConfigurationProvider)
                .ToList();

            return this.View(models);
        }

        [HttpPost]
        public IActionResult Register(RegisterEmployeeInputModel model)
        {
           

            var employee = this.mapper.Map<Employee>(model);

            this.context.Employees.Add(employee);

            this.context.SaveChanges();

            return this.RedirectToAction("All", "Employees");

        }

        public IActionResult All()
        {
            var categories = this.context.Employees
               .ProjectTo<EmployeesAllViewModel>(mapper.ConfigurationProvider)
               .ToList();

            return this.View(categories);
        }
    }
}
