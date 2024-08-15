using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.ViewModel.ViewModels;
using System.Net.Http.Json;

namespace RealEstate.Dapper.Shared.Services.ApiReadService
{
    public class EstateAgentDashboardReadApiService : IEstateAgentDashboardReadApiService
    {
        private readonly HttpClient _httpClient;

        public EstateAgentDashboardReadApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GetProductCountByEmployeeIdViewModel> GetProductCountByEmployeeId(int userId)
        {
            return await _httpClient.GetFromJsonAsync<GetProductCountByEmployeeIdViewModel>($"ProductCountByEmployeeId/{userId}");
        }

        public async Task<GetProductCountByStatusFalseViewModel> GetProductCountByStatusFalse(int userId)
        {
           return await _httpClient.GetFromJsonAsync<GetProductCountByStatusFalseViewModel>($"ProductCountByStatusFalse/{userId}");
        }

        public async Task<GetProductCountByStatusTrueViewModel> GetProductCountByStatusTrue(int userId)
        {
            return await _httpClient.GetFromJsonAsync<GetProductCountByStatusTrueViewModel>($"ProductCountByStatusTrue/{userId}");
        }

        public async Task<List<ResultCityCountViewModel>> ResultCityCount()
        {
            return await _httpClient.GetFromJsonAsync<List<ResultCityCountViewModel>>($"GetLastFiveCountCity");
        }
    }
}
