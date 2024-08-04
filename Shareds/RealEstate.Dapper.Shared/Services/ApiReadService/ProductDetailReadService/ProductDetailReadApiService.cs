using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Services.ApiReadService
{
    public class ProductDetailReadApiService : BaseReadApiService<ResultProductAndDetailListViewModel>, IProductDetailReadApiService
    {
        public ProductDetailReadApiService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}
