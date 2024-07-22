using AutoMapper;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Model;
using RealEstate.Dapper.WebAPI.Tools;

namespace RealEstate.Dapper.WebAPI.Mappings
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<GetCheckUserModel, LoginUserQueryResult>().ReverseMap();
        }
    }
}
