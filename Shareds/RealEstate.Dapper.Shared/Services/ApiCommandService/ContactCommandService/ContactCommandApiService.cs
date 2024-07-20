using RealEstate.Dapper.Shared.Abstract.IApiCommandService;
using RealEstate.Dapper.ViewModel.ViewModels;
using System.Net.Http.Json;

namespace RealEstate.Dapper.Shared.Services.ApiCommandService
{
    public class ContactCommandApiService : IContactCommandApiService
    {
        private readonly HttpClient _httpClient;

        public ContactCommandApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> CreateContact(CreateContactViewModel createContactViewModel)
        {
            return await _httpClient.PostAsJsonAsync<CreateContactViewModel>(string.Empty, createContactViewModel);

        }
    }
}
