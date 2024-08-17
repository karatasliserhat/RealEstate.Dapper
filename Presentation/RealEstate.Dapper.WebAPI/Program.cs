using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Application.Service;
using RealEstate.Dapper.Persistence.Context;
using RealEstate.Dapper.Persistence.Repositories;
using RealEstate.Dapper.WebAPI.Hubs;
using RealEstate.Dapper.WebAPI.Tools;
using System.Data;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", policy =>
    {
        policy.WithOrigins("https://localhost:7029").AllowAnyHeader().AllowAnyMethod().AllowCredentials();
    });
});
builder.Services.AddSignalR();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection = builder.Configuration.GetConnectionString("DapperConncetion");
builder.Services.AddDbContext<DapperContext>(opt =>
{
    opt.UseSqlServer(connection);
});
builder.Services.AddScoped<IDbConnection>(sp =>
{
    return new SqlConnection(connection);
});

builder.Services.Configure<JwtTokenModel>(builder.Configuration.GetSection("JwtTokenModel"));

builder.Services.AddScoped<IJwtTokenModel>(conf =>
{
    return conf.GetRequiredService<IOptions<JwtTokenModel>>().Value;
});


builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());


builder.Services.AddApplicationService();
builder.Services.AddScoped<JwtTokenGenerator>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IAboutDetailRepository, AboutDetailRepository>();
builder.Services.AddScoped<IAboutServiceRepository, AboutServiceRepository>();
builder.Services.AddScoped<IStepsGridRepository, StepsGridRepository>();
builder.Services.AddScoped<IPopulerLocationRepository, PopulerLocationRepository>();
builder.Services.AddScoped<ITestimonialRepository, TestimonialRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IStatisticsRepository, StatisticsRepository>();
builder.Services.AddScoped<IContactRepository, ContactRepository>();
builder.Services.AddScoped<IToDoListRepository, ToDolistRepository>();
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<IEstateAgentDashboardRepository, EstateAgentDashboardRepository>();
builder.Services.AddScoped<IMessageRepository, MessageRepository>();
builder.Services.AddScoped<IProductDetailRepository, ProductDetailRepository>();
builder.Services.AddScoped<IProductImagesRepository, ProductImagesRepository>();
builder.Services.AddScoped<IAppUserRepository, AppUserRepository>();
builder.Services.AddScoped<IProperyAmenityRepository, ProperyAmenityRepository>();
builder.Services.AddScoped<ISubFeatureRepository, SubFeatureRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapHub<SignalRHub>("/signalrhub");
app.Run();
