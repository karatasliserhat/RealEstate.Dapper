using RealEstate.Dapper.Shared.Abstract.IApiCommandService;
using RealEstate.Dapper.ViewModel.ViewModels;
using System.Net.Http.Json;

namespace RealEstate.Dapper.Shared.Services.ApiCommandService
{
    public class ProductCommandApiService : BaseCommandApiService<UpdateProductViewModel, CreateProductViewModel>, IProductCommandApiService
    {
        private readonly HttpClient _httpClient;
        public ProductCommandApiService(HttpClient httpClient) : base(httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> DealOfTheDayFalse(int id)
        {
            return await _httpClient.GetAsync($"DealOfTheDayFalse/{id}");

        }

        public async Task<HttpResponseMessage> DealOfTheDayTrue(int id)
        {
            return await _httpClient.GetAsync($"DealOfTheDayTrue/{id}");
        }
    }
}
