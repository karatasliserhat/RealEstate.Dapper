using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.ViewModel.ViewModels;
using System.Net.Http.Json;

namespace RealEstate.Dapper.Shared.Services.ApiReadService
{
    public class ContactReadApiService : BaseReadApiService<ResultContactViewModel>, IContactReadApiService
    {
        private readonly HttpClient _httpClient;
        public ContactReadApiService(HttpClient httpClient) : base(httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ResultContactViewModel>> GetLastContactsAsync(int HowContactCount)
        {
            return await _httpClient.GetFromJsonAsync<List<ResultContactViewModel>>($"GetLastContact/{HowContactCount}");
        }
    }
}
