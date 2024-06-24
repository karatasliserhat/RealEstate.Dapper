using AutoMapper;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Domain.Entities;

namespace RealEstate.Dapper.Application.Mappings
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Category, GetCategoryQueryResult>().ReverseMap();
            CreateMap<Category, GetCategoryByIdQueryResult>().ReverseMap();
            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
            CreateMap<Category, UpdateCategoryCommand>().ReverseMap();
        }
    }
}
