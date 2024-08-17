using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Services.ApiReadService
{
    public class SubFeatureReadApiService : BaseReadApiService<ResultSubFeature>, ISubFeatureReadApiService
    {
        public SubFeatureReadApiService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}
