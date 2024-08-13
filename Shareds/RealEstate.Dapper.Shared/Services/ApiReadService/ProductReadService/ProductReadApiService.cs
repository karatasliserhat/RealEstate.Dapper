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

        public async Task<List<ResultProductWithCategoryAndAppUser>> GetListLastProductAsync(int HowProductCount)
        {
            return await _httpClient.GetFromJsonAsync<List<ResultProductWithCategoryAndAppUser>>($"GetListLastProduct/{HowProductCount}");
        }
        public async Task<List<ResultProductWithCategoryAndAppUser>> GetListLastProductAsync(int HowProductCount, int UserId)
        {
            return await _httpClient.GetFromJsonAsync<List<ResultProductWithCategoryAndAppUser>>($"GetListLastProduct/{HowProductCount}/{UserId}");
        }

        public async Task<List<ResultProductWithCategoryAndAppUser>> GetListProductByUserAsync(int UserId, bool status)
        {
            return await _httpClient.GetFromJsonAsync<List<ResultProductWithCategoryAndAppUser>>($"GetListProductByUserAndTrueOrFalse/{UserId}/{status}");
        }

        public async Task<List<ResultProductWithCategoryAndAppUser>> GetListProductWithCategoryAndEmployeeAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<ResultProductWithCategoryAndAppUser>>("");
        }
    }
}
