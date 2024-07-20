using RealEstate.Dapper.Shared.Abstract.IApiReadService.IProductReadService;
using RealEstate.Dapper.ViewModel.ViewModels;
using System.Net.Http.Json;

namespace RealEstate.Dapper.Shared.Services.ApiReadService.ProductReadService
{
    public class ProductReadApiService : BaseReadApiService<ResultProductViewModel>, IProductReadApiService
    {
        private readonly HttpClient _httpClient;
        public ProductReadApiService(HttpClient httpClient) : base(httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ResultProductWithCategoryAndEmployee>> GetListLastProductAsync(int HowProductCount)
        {
            return await _httpClient.GetFromJsonAsync<List<ResultProductWithCategoryAndEmployee>>($"GetListLastProduct/{HowProductCount}");
        }

        public async Task<List<ResultProductWithCategoryAndEmployee>> GetListProductWithCategoryAndEmployeeAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<ResultProductWithCategoryAndEmployee>>("");
        }
    }
}
