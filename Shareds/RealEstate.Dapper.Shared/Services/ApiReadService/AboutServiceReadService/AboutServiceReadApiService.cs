using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Services.ApiReadService
{
    public class AboutServiceReadApiService : BaseReadApiService<ResultAboutServiceViewModel>, IAboutServiceReadApiService
    {
        public AboutServiceReadApiService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}
