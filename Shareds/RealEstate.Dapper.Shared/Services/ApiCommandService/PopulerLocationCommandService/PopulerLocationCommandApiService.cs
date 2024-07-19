using RealEstate.Dapper.Shared.Abstract.IApiCommandService;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Services.ApiCommandService
{
    public class PopulerLocationCommandApiService : BaseCommandApiService<UpdatePopulerLocationViewModel, CreatePopulerLocationViewModel>, IPopulerLocationCommandApiService
    {
        public PopulerLocationCommandApiService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}
