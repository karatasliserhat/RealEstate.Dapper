using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Services.ApiReadService.AboutDetailReadService
{
    public class AboutDetailReadApiService : BaseReadApiService<ResultAboutDetailViewModel>, IAboutDetailReadApiService
    {
        public AboutDetailReadApiService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}
