using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Services.ApiReadService
{
    public class StepsGridReadApiService : BaseReadApiService<ResultStepsGridViewModel>, IStepGridReadApiService
    {
        public StepsGridReadApiService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}
