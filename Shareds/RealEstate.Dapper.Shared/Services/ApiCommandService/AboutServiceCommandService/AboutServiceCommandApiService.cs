using RealEstate.Dapper.Shared.Abstract.IApiCommandService;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Services.ApiCommandService
{
    public class AboutServiceCommandApiService : BaseCommandApiService<UpdateAboutServiceViewModel, CreateAboutServiceViewModel>, IAboutServiceCommandApiService
    {
        public AboutServiceCommandApiService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}
