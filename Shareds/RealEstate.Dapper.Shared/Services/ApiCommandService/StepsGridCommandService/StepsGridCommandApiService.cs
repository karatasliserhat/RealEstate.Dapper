using RealEstate.Dapper.Shared.Abstract.IApiCommandService;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Services.ApiCommandService
{
    public class StepsGridCommandApiService : BaseCommandApiService<UpdateStepsGridViewModel, CreateStepsGridViewModel>, IStepsGridCommandApiService
    {
        public StepsGridCommandApiService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}
