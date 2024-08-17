using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Application.Service;
using RealEstate.Dapper.Persistence.Context;
using RealEstate.Dapper.Persistence.Repositories;
using RealEstate.Dapper.WebAPI.Tools;
using System.Data;
using System.Reflection;

namespace RealEstate.Dapper.WebAPI.Containers
{
    public static class Extensions
    {
        public static void ContinerDependencies(this IServiceCollection Services, IConfiguration Configuration)
        {

            

            var connection = Configuration.GetConnectionString("DapperConncetion");
            Services.AddDbContext<DapperContext>(opt =>
            {
                opt.UseSqlServer(connection);
            });
            Services.AddScoped<IDbConnection>(sp =>
            {
                return new SqlConnection(connection);
            });

            Services.Configure<JwtTokenModel>(Configuration.GetSection("JwtTokenModel"));

            Services.AddScoped<IJwtTokenModel>(conf =>
            {
                return conf.GetRequiredService<IOptions<JwtTokenModel>>().Value;
            });



            Services.AddAutoMapper(Assembly.GetExecutingAssembly());

            Services.AddApplicationService();
            Services.AddScoped<JwtTokenGenerator>();
            Services.AddScoped<ICategoryRepository, CategoryRepository>();
            Services.AddScoped<IProductRepository, ProductRepository>();
            Services.AddScoped<IAboutDetailRepository, AboutDetailRepository>();
            Services.AddScoped<IAboutServiceRepository, AboutServiceRepository>();
            Services.AddScoped<IStepsGridRepository, StepsGridRepository>();
            Services.AddScoped<IPopulerLocationRepository, PopulerLocationRepository>();
            Services.AddScoped<ITestimonialRepository, TestimonialRepository>();
            Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            Services.AddScoped<IStatisticsRepository, StatisticsRepository>();
            Services.AddScoped<IContactRepository, ContactRepository>();
            Services.AddScoped<IToDoListRepository, ToDolistRepository>();
            Services.AddScoped<IAccountRepository, AccountRepository>();
            Services.AddScoped<IEstateAgentDashboardRepository, EstateAgentDashboardRepository>();
            Services.AddScoped<IMessageRepository, MessageRepository>();
            Services.AddScoped<IProductDetailRepository, ProductDetailRepository>();
            Services.AddScoped<IProductImagesRepository, ProductImagesRepository>();
            Services.AddScoped<IAppUserRepository, AppUserRepository>();
            Services.AddScoped<IProperyAmenityRepository, ProperyAmenityRepository>();
            Services.AddScoped<ISubFeatureRepository, SubFeatureRepository>();
        }
    }
}
