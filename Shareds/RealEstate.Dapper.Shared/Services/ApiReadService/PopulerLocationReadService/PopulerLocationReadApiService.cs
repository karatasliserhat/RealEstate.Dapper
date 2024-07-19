using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Services.ApiReadService
{
    public class PopulerLocationReadApiService : BaseReadApiService<ResultPopulerLocationViewModel>, IPopulerLocationReadApiService
    {
        public PopulerLocationReadApiService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}
