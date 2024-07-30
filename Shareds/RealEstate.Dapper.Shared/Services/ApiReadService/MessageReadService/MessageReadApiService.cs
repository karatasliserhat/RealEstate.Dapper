using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.ViewModel.ViewModels;
using System.Net.Http.Json;

namespace RealEstate.Dapper.Shared.Services.ApiReadService
{
    public class MessageReadApiService : IMessageReadApiService
    {
        private readonly HttpClient _httpClient;

        public MessageReadApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ResultInBoxMessage>> GetInBoxMessageListAsync(int ReceiveId, int HowMessageCount)
        {
            return await _httpClient.GetFromJsonAsync<List<ResultInBoxMessage>>($"GetInBoxMessage/{ReceiveId}/{HowMessageCount}");
        }
    }
}
