using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.ViewModel.ViewModels;
using System.Net.Http.Json;

namespace RealEstate.Dapper.Shared.Services.ApiReadService
{
    public class ProductImageReadApiService : BaseReadApiService<ResultProductImageViewModel>, IProductImageReadApiService
    {
        private readonly HttpClient _httpClient;
        public ProductImageReadApiService(HttpClient httpClient) : base(httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ResultProductImageViewModel>> GetProductImageListByProductIdAsync(int productId)
        {
            return await _httpClient.GetFromJsonAsync<List<ResultProductImageViewModel>>($"GetProductImageListByProductId/{productId}");
        }
    }
}
