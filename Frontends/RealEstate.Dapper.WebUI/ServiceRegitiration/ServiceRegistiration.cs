﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using RealEstate.Dapper.Shared.Abstract.IApiCommandService;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.Shared.Abstract.IApiReadService.IProductReadService;
using RealEstate.Dapper.Shared.Abstract.IUserServices;
using RealEstate.Dapper.Shared.Services.ApiCommandService;
using RealEstate.Dapper.Shared.Services.ApiReadService;
using RealEstate.Dapper.Shared.Services.ApiReadService.AboutDetailReadService;
using RealEstate.Dapper.Shared.Services.ApiReadService.ProductReadService;
using RealEstate.Dapper.Shared.Services.UserServices;
using RealEstate.Dapper.Shared.Settings;
using RealEstate.Dapper.WebUI.Tools;
using System.Reflection;

namespace RealEstate.Dapper.WebUI.ServiceRegitiration
{
    public static class ServiceRegistiration
    {
        public static void AddServiceRegister(this IServiceCollection Services, IConfiguration configuration)
        {

            Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddCookie(JwtBearerDefaults.AuthenticationScheme, conf =>
            {
                conf.LoginPath = new PathString("/Account/Login");
                conf.LogoutPath = new PathString("/Account/Logout");
                conf.AccessDeniedPath = new PathString("/Pages/AccessDenied");
                conf.Cookie.Name = "RealEStateCookie";
                conf.Cookie.SameSite = SameSiteMode.Strict;
                conf.Cookie.HttpOnly = true;
                conf.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;

            });

            Services.AddScoped<IUserService, UserService>();

            Services.AddHttpContextAccessor();
            Services.AddDataProtection();
            Services.AddAutoMapper(Assembly.GetExecutingAssembly());
            Services.Configure<ApiSettings>(configuration.GetSection(nameof(ApiSettings)));


            Services.AddScoped<GetAppUserAndCategorySelectList>();
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
            Services.AddHttpClient<IProductCommandApiService, ProductCommandApiService>(opt =>
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

            Services.AddHttpClient<IAboutServiceReadApiService, AboutServiceReadApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.AboutServiceBaseUrl.ToString());
            });
            Services.AddHttpClient<IAboutServiceCommandApiService, AboutServiceCommandApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.AboutServiceBaseUrl.ToString());
            });

            Services.AddHttpClient<IStepGridReadApiService, StepsGridReadApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.StepsGridBaseUrl.ToString());
            });
            Services.AddHttpClient<IStepsGridCommandApiService, StepsGridCommandApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.StepsGridBaseUrl.ToString());
            });

            Services.AddHttpClient<IPopulerLocationReadApiService, PopulerLocationReadApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.PopulerLocationBaseUrl.ToString());
            });
            Services.AddHttpClient<IPopulerLocationCommandApiService, PopulerLocationCommandApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.PopulerLocationBaseUrl.ToString());
            });

            Services.AddHttpClient<ITestimonialReadApiService, TestimonialReadApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.TestimonialBaseUrl.ToString());
            });
            Services.AddHttpClient<ITestimonialCommandApiService, TestimonialCommandApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.TestimonialBaseUrl.ToString());
            });

            Services.AddHttpClient<ICategoryReadApiService, CategoryReadApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.CategoryBaseUrl.ToString());
            });
            Services.AddHttpClient<ICategoryCommandApiService, CategoryCommandApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.CategoryBaseUrl.ToString());
            });

            Services.AddHttpClient<IEmployeeReadApiService, EmployeeReadApiService>(opt =>
            {

                opt.BaseAddress = new Uri(apiUrl.EmployeeBaseUrl.ToString());
            });
            Services.AddHttpClient<IEmployeeCommandApiService, EmployeeCommandApiService>(opt =>
            {

                opt.BaseAddress = new Uri(apiUrl.EmployeeBaseUrl.ToString());
            });

            Services.AddScoped(typeof(IStatisticsReadApiService<>), typeof(StatisticsReadApiService<>)).ConfigureHttpClientDefaults(opt =>
            {
                opt.ConfigureHttpClient(opt =>
                {
                    opt.BaseAddress = new Uri(apiUrl.StatisticsBaseUrl.ToString());
                });
            });

            Services.AddHttpClient<IContactCommandApiService, ContactCommandApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.ContactBaseUrl.ToString());
            });

            Services.AddHttpClient<IContactReadApiService, ContactReadApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.ContactBaseUrl.ToString());
            });

            Services.AddHttpClient<IToDoListCommandApiService, ToDoListCommandApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.ToDoListBaseUrl.ToString());
            });

            Services.AddHttpClient<IToDoListReadApiService, ToDoListReadApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.ToDoListBaseUrl.ToString());
            });
            Services.AddHttpClient<IAccountCommandApiService, AccountCommandApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.AccountBaseUrl.ToString());
            });

            Services.AddHttpClient<IEstateAgentDashboardReadApiService, EstateAgentDashboardReadApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.EstateAgentBaseUrl.ToString());
            });

            Services.AddHttpClient<IMessageReadApiService, MessageReadApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.MessageBaseUrl.ToString());
            });

            Services.AddHttpClient<IProductDetailReadApiService, ProductDetailReadApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.ProductDetailBaseUrl.ToString());
            });

            Services.AddHttpClient<IProductImageReadApiService, ProductImageReadApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.ProductImageBaseUrl.ToString());
            });

            Services.AddHttpClient<IAppUserReadApiService, AppUserReadApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.AppUserBaseUrl.ToString());
            });

            Services.AddHttpClient<IPropertyAmenityReadApiService, PropertyAmenityReadApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.PropertyAmenityBaseUrl.ToString());
            });
            
            Services.AddHttpClient<ISubFeatureReadApiService, SubFeatureReadApiService>(opt =>
            {
                opt.BaseAddress = new Uri(apiUrl.SubFeatureBaseUrl.ToString());
            });
        }
    }
}
