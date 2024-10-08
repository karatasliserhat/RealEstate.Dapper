﻿using AutoMapper;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Domain.Entities;

namespace RealEstate.Dapper.Application.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Category, GetCategoryQueryResult>().ReverseMap();
            CreateMap<Category, GetCategoryByIdQueryResult>().ReverseMap();
            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
            CreateMap<Category, UpdateCategoryCommand>().ReverseMap();

            CreateMap<AboutDetail, GetAboutDetailQueryResult>().ReverseMap();
            CreateMap<AboutDetail, GetByIdAboutDetailQueryResult>().ReverseMap();
            CreateMap<AboutDetail, CreateAboutDetailCommand>().ReverseMap();
            CreateMap<AboutDetail, UpdateAboutDetailCommand>().ReverseMap();

            CreateMap<AboutService, GetAboutServiceQueryResult>().ReverseMap();
            CreateMap<AboutService, GetAboutServiceByIdQueryResult>().ReverseMap();
            CreateMap<AboutService, CreateAboutServiceCommand>().ReverseMap();
            CreateMap<AboutService, UpdateAboutServiceCommand>().ReverseMap();

            CreateMap<StepsGrid, GetStepsGridQueryResult>().ReverseMap();
            CreateMap<StepsGrid, GetStepsGridByIdQueryResult>().ReverseMap();
            CreateMap<StepsGrid, CreateStepsGridCommand>().ReverseMap();
            CreateMap<StepsGrid, UpdateStepsGridCommand>().ReverseMap();

            CreateMap<PopulerLocation, GetPopulerLocationQueryResult>().ReverseMap();
            CreateMap<PopulerLocation, GetPopulerLocationByIdQueryResult>().ReverseMap();
            CreateMap<PopulerLocation, CreatePopulerLocationCommand>().ReverseMap();
            CreateMap<PopulerLocation, UpdatePopulerLocationCommand>().ReverseMap(); 
            
            CreateMap<Testimonial, GetTestimonialQueryResult>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialByIdQueryResult>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialCommand>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialCommand>().ReverseMap();


            CreateMap<Product, GetProductByIdQueryResult>().ReverseMap();
            CreateMap<Product, UpdateProductCommand>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();

            CreateMap<Employee, GetEmployeeQueryResult>().ReverseMap();
            CreateMap<Employee, GetEmployeeByIdQueryResult>().ReverseMap();
            CreateMap<Employee, CreateEmployeeCommand>().ReverseMap();
            CreateMap<Employee, UpdateEmployeeCommand>().ReverseMap();

            CreateMap<Contact, CreateContactCommand>().ReverseMap();
            CreateMap<Contact, GetContactByIdQueryResult>().ReverseMap();
            CreateMap<Contact, GetContactQueryResult>().ReverseMap();

            CreateMap<ToDoList, GetToDoListQueryResult>().ReverseMap();
            CreateMap<ToDoList, GetToDoListByIdQueryResult>().ReverseMap();
            CreateMap<ToDoList, CreateToDoListCommand>().ReverseMap();
            CreateMap<ToDoList, UpdateToDoListCommand>().ReverseMap();
        }
    }
}
