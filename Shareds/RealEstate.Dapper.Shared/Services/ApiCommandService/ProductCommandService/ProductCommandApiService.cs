using RealEstate.Dapper.Shared.Abstract.IApiCommandService;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Services.ApiCommandService
{
    public class ProductCommandApiService : BaseCommandApiService<UpdateProductViewModel, CreateProductViewModel>, IProductCommandApiService
    {
        public ProductCommandApiService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}
