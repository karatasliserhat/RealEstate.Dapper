using Microsoft.Extensions.Options;
using RealEstate.Dapper.Shared.Abstract.IApiCommandService;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.Shared.Abstract.IApiReadService.IProductReadService;
using RealEstate.Dapper.Shared.Services.ApiCommandService;
using RealEstate.Dapper.Shared.Services.ApiReadService;
using RealEstate.Dapper.Shared.Services.ApiReadService.AboutDetailReadService;
using RealEstate.Dapper.Shared.Services.ApiReadService.ProductReadService;
using RealEstate.Dapper.Shared.Settings;

namespace RealEstate.Dapper.WebUI.ServiceRegitiration
{
    public static class ServiceRegistiration
    {
        public static void AddServiceRegister(this IServiceCollection Services, IConfiguration configuration)
        {
            Services.Configure<ApiSettings>(configuration.GetSection(nameof(ApiSettings)));

            Services.AddScoped<IApiSettings>(sp =>
            {
                return sp.GetRequiredService<IOptions<ApiSettings>>().Value;
            });

            Services.AddScoped(typeof(IBaseReadApiService<>), typeof(BaseReadApiService<>));
            Services.AddScoped(typeof(IBaseCommandApiService<,>), typeof(BaseCommandApiService<,>));

            Services.AddScoped<IProductReadApiService, ProductReadApiService>();

            Services.AddScoped<IAboutDetailReadApiService, AboutDetailReadApiService>();
            Services.AddScoped<IAboutDetailCommandApiService, AboutDetailCommandApiService>();

            var scope = Services.BuildServiceProvider();

            var apiUrl = scope.GetRequiredService<IOptions<ApiSettings>>().Value;

            Services.AddHttpClient<IProductReadApiService, ProductReadApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.ProductBaseUrl.ToString());
            });

            Services.AddHttpClient<IAboutDetailReadApiService, AboutDetailReadApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.AboutDetailBaseUrl.ToString());
            });
            Services.AddHttpClient<IAboutDetailCommandApiService, AboutDetailCommandApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.AboutDetailBaseUrl.ToString());
            });
        }
    }
}
