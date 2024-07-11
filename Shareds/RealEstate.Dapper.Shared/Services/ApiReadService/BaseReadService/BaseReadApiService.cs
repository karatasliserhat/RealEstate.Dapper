using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using System.Net.Http.Json;

namespace RealEstate.Dapper.Shared.Services.ApiReadService
{
    public class BaseReadApiService<ResultViewModel> : IBaseReadApiService<ResultViewModel> where ResultViewModel : class
    {
        private readonly HttpClient _httpClient;

        public BaseReadApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResultViewModel> GetByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<ResultViewModel>($"{id}");
        }
        public async Task<ResultViewModel> GetByIdAsync(string ActionName, int id)
        {
            return await _httpClient.GetFromJsonAsync<ResultViewModel>($"{ActionName}/{id}");
        }
        public async Task<ResultViewModel> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<ResultViewModel>($"{id}");
        }

        public async Task<List<ResultViewModel>> GetListAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<ResultViewModel>>(string.Empty);
        }

        public async Task<List<ResultViewModel>> GetListAsync(string actionName)
        {
            return await _httpClient.GetFromJsonAsync<List<ResultViewModel>>($"{actionName}");
        }
    }
}
