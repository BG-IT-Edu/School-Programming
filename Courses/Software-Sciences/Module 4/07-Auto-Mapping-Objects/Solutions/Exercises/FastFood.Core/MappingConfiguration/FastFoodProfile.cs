namespace FastFood.Core.MappingConfiguration
{
    using AutoMapper;
    using FastFood.Core.ViewModels.Categories;
    using FastFood.Core.ViewModels.Employees;
    using FastFood.Core.ViewModels.Items;
    using FastFood.Core.ViewModels.Orders;
    using FastFood.Models;
    using FastFood.Models.Enums;
    using System;
    using ViewModels.Positions;

    public class FastFoodProfile : Profile
    {
        public FastFoodProfile()
        {
            //Positions
            this.CreateMap<CreatePositionInputModel, Position>()
                .ForMember(x => x.Name, y => y.MapFrom(s => s.PositionName));

            this.CreateMap<Position, PositionsAllViewModel>()
                .ForMember(x => x.Name, y => y.MapFrom(s => s.Name));

            //Employee

            this.CreateMap<Position, RegisterEmployeeViewModel>()
                .ForMember(re=>re.PositionId,p=>p.MapFrom(p=>p.Id));

            this.CreateMap<RegisterEmployeeInputModel, Employee>();

            this.CreateMap<Employee, EmployeesAllViewModel>()
                .ForMember(x => x.Position, e => e.MapFrom(ep => ep.Position.Name));

            //Categories

            this.CreateMap<CreateCategoryInputModel, Category>()
                .ForMember(x=>x.Name,cci=>cci.MapFrom(x=>x.CategoryName));

            this.CreateMap<Category, CategoryAllViewModel>();

            //Items

            this.CreateMap<Category, CreateItemViewModel>()
            .ForMember(x => x.CategoryId, m => m.MapFrom(x => x.Id));

            this.CreateMap<CreateItemInputModel,Item>();

            this.CreateMap<Item, ItemsAllViewModels>()
                .ForMember(x => x.Category, i => i.MapFrom(x => x.Category.Name));

            //Order

            this.CreateMap< CreateOrderInputModel, Order>()
                .ForMember(x => x.DateTime, y => y.MapFrom(s => DateTime.UtcNow))
                .ForMember(x => x.Type, y => y.MapFrom(s => OrderType.ToGo)); 

            this.CreateMap<CreateOrderInputModel,OrderItem>();

            this.CreateMap<Order, OrderAllViewModel>()
                .ForMember(x => x.Employee, o => o.MapFrom(x => x.Employee.Name))
                .ForMember(x => x.OrderId, o => o.MapFrom(x => x.Id))
                .ForMember(x => x.DateTime, o => o.MapFrom(x => x.DateTime.ToString("MM/dd/yyyy")));

        }
    }
}
