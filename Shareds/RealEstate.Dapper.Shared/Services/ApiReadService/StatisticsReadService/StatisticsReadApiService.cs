using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using System.Net.Http.Json;

namespace RealEstate.Dapper.Shared.Services.ApiReadService
{
    public class StatisticsReadApiService<ResultViewModel> : IStatisticsReadApiService<ResultViewModel> where ResultViewModel : class
    {
        private readonly HttpClient _httpClient;

        public StatisticsReadApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResultViewModel> GetStatisticResult(string ActionName)
        {
            var result = await _httpClient.GetFromJsonAsync<ResultViewModel>(ActionName);
            return result;
        }
    }
}
