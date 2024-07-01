using RealEstate.Dapper.Shared.Abstract.IApiCommandService;
using System.Net.Http.Json;

namespace RealEstate.Dapper.Shared.Services.ApiCommandService
{
    public class BaseCommandApiService<UpdateViewModel, CreateViewModel> : IBaseCommandApiService<UpdateViewModel, CreateViewModel>
        where UpdateViewModel : class
        where CreateViewModel : class
    {
        private readonly HttpClient _httpClient;

        public BaseCommandApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> CreateAsync(CreateViewModel createViewModel)
        {
            var response=await _httpClient.PostAsJsonAsync<CreateViewModel>(string.Empty, createViewModel);
            return response;

        }

        public async Task<HttpResponseMessage> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{id}");
            return response;
        }

        public async Task<HttpResponseMessage> UpdateAsync(UpdateViewModel updateViewModel)
        {
            var response = await _httpClient.PutAsJsonAsync<UpdateViewModel>(string.Empty, updateViewModel);
            return response;
        }
    }
}
