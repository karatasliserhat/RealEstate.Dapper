using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using System.Net.Http.Json;

namespace RealEstate.Dapper.Shared.Services.ApiReadService
{
    public class EstateAgentDashboardReadApiService<GetResultViewCountModel> : IEstateAgentDashboardReadApiService<GetResultViewCountModel> where GetResultViewCountModel : class
    {
        private readonly HttpClient _httpClient;

        public EstateAgentDashboardReadApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GetResultViewCountModel> GetResultViewCount(string Action, int id)
        {
            return await _httpClient.GetFromJsonAsync<GetResultViewCountModel>($"{Action}/{id}");
        }

        public async Task<GetResultViewCountModel> GetResultViewCount(string Action)
        {
            return await _httpClient.GetFromJsonAsync<GetResultViewCountModel>($"{Action}");
        }
    }
}
