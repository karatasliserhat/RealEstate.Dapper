using AutoMapper;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.WebUI.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<ResultCategoryViewModel, UpdateCategoryViewModel>().ReverseMap();
            CreateMap<ResultProductViewModel, UpdateProductViewModel>().ReverseMap();
            CreateMap<ResultAboutDetailViewModel, UpdateAboutDetailViewModel>().ReverseMap();
            CreateMap<ResultAboutServiceViewModel, UpdateAboutServiceViewModel>().ReverseMap();
            CreateMap<ResultPopulerLocationViewModel, UpdatePopulerLocationViewModel>().ReverseMap();
        }
    }
}
