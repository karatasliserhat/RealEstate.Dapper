using RealEstate.Dapper.Shared.Abstract.IApiCommandService;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Services.ApiCommandService
{
    public class AboutDetailCommandApiService : BaseCommandApiService<UpdateAboutDetailViewModel, CreateAboutDetailViewModel>, IAboutDetailCommandApiService
    {
        public AboutDetailCommandApiService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}
