using RealEstate.Dapper.Shared.Abstract.IApiCommandService;
using RealEstate.Dapper.ViewModel.ViewModels;
using System.Text;
using System.Text.Json;

namespace RealEstate.Dapper.Shared.Services.ApiCommandService
{
    public class AccountCommandApiService : IAccountCommandApiService
    {
        private readonly HttpClient _httpClient;

        public AccountCommandApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<TokenViewModel> UserLoginAsync(LoginUserModel loginUserModel)
        {
            
                var content = new StringContent(JsonSerializer.Serialize(loginUserModel), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync(string.Empty, content);
                if (response.IsSuccessStatusCode)
                {
                    var jsonConvert = await response.Content.ReadAsStringAsync();
                    var value = JsonSerializer.Deserialize<TokenViewModel>(jsonConvert, new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    });
                    return value;
                }
            
            
            return null;
        }
    }
}
