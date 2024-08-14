using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.ViewModel.ViewModels;
using System.Net.Http.Json;

namespace RealEstate.Dapper.Shared.Services.ApiReadService
{
    public class PropertyAmenityReadApiService : IPropertyAmenityReadApiService
    {
        private readonly HttpClient _httpClient;

        public PropertyAmenityReadApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ResultPropertyAmenityByProductIdViewModel>> GetPropertyAmenityByProductId(int ProductId)
        {
           var values= await _httpClient.GetFromJsonAsync<List<ResultPropertyAmenityByProductIdViewModel>>($"GetProperyAmenityByProductId/{ProductId}");
            return values;
        }

        public async Task<List<ResultPropertyAmenityByProductIdStatusFalseViewModel>> GetPropertyAmenityByProductIdStatusFalse(int ProductId)
        {
            var values = await _httpClient.GetFromJsonAsync<List<ResultPropertyAmenityByProductIdStatusFalseViewModel>>($"GetProperyAmenityByProductIdStatusFalse/{ProductId}");
            return values;
        }

        public async Task<List<ResultPropertyAmenityByProductIdStatusTrueViewModel>> GetPropertyAmenityByProductIdStatusTrue(int ProductId)
        {
            var values = await _httpClient.GetFromJsonAsync<List<ResultPropertyAmenityByProductIdStatusTrueViewModel>>($"GetProperyAmenityByProductIdStatusTrue/{ProductId}");
            return values;
        }
    }
}
