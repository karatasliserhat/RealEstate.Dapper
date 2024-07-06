using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Application.Service;
using RealEstate.Dapper.Persistence.Context;
using RealEstate.Dapper.Persistence.Repositories;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
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

builder.Services.AddApplicationService();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IAboutDetailRepository, AboutDetailRepository>();
builder.Services.AddScoped<IAboutServiceRepository, AboutServiceRepository>();
builder.Services.AddScoped<IStepsGridRepository, StepsGridRepository>();
builder.Services.AddScoped<IPopulerLocationRepository, PopulerLocationRepository>();
builder.Services.AddScoped<ITestimonialRepository, TestimonialRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
