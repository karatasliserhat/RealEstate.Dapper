﻿using Dapper;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;
using System.Data;

namespace RealEstate.Dapper.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;
        private readonly DynamicParameters _dynamicParameters;

        public ProductRepository(IDbConnection connection)
        {
            _connection = connection;
            _dynamicParameters = new DynamicParameters();
        }

        public async Task CreateAsync(Product entity)
        {
            var query = "Insert Into Products (Title,Price,CoverImage,City,District,Address,Description,Type,CategoryId,EmployeeId) Values(@title,@price,@coverImage,@city,@district,@address,@description,@type,@categoryId,@employeeId)";
            _dynamicParameters.Add("@title", entity.Title);
            _dynamicParameters.Add("@price", entity.Price);
            _dynamicParameters.Add("@coverImage", entity.CoverImage);
            _dynamicParameters.Add("@city", entity.City);
            _dynamicParameters.Add("@district", entity.District);
            _dynamicParameters.Add("@address", entity.Address);
            _dynamicParameters.Add("@description", entity.Description);
            _dynamicParameters.Add("@type", entity.Type);
            _dynamicParameters.Add("@categoryId", entity.CategoryId);
            _dynamicParameters.Add("@employeeId", entity.EmployeeId);
            await _connection.ExecuteAsync(query, _dynamicParameters);
        }

        public async Task DeleteAsync(int id)
        {
            var query = $"Delete From Products Where Id={id}";
            await _connection.ExecuteAsync(query);
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            var query = $"Select * From Products Where Id={id}";
            var values = await _connection.QueryAsync<Product>(query);
            return values.FirstOrDefault();
        }

        public async Task<GetProductByIdWithCategoryAndEmployeeQueryResult> GetByIdWithCategoryAndEmployeeAsync(int id)
        {
            var query = $"Select Products.Id,Products.Title,Products.Price,Products.CoverImage,Products.City,Products.District,Products.Address,Products.Type,CategoryName,EmployeeName From Products Inner Join Categories on Products.CategoryId=Categories.Id Inner Join Employees on Products.EmployeeId=Employees.Id where Products.Id={id}";
            var values = await _connection.QueryAsync<GetProductByIdWithCategoryAndEmployeeQueryResult>(query, _dynamicParameters);
            return values.FirstOrDefault();


        }

        public async Task<List<Product>> GetListAsync()
        {
            var query = "Select * From Products";
            var values = await _connection.QueryAsync<Product>(query);
            return values.ToList();
        }

        public async Task<List<GetListProductWithCategoryAndEmployeeQueryResult>> GetListProductWithEmployeeAndCategory()
        {
            var query = "Select Products.Id,Products.Title,Products.Price,Products.CoverImage,Products.City,Products.District,Products.Address,Products.Type,CategoryName,EmployeeName From Products inner join Categories on Products.CategoryId=Categories.Id inner join Employees on Products.EmployeeId=Employees.Id";
            var values = await _connection.QueryAsync<GetListProductWithCategoryAndEmployeeQueryResult>(query);
            return values.ToList();
        }

        public async Task UpdateAsync(Product entity)
        {
            var query = $"Update Products Set Title=@title,Price=@price,CoverImage=@coverImage,City=@city,District=@district,Address=@address,Description=@description,Type=@type,CategoryId=@categoryId,EmployeeId=@employeeId Where Id=@id";

            _dynamicParameters.Add("@title", entity.Title);
            _dynamicParameters.Add("@price", entity.Price);
            _dynamicParameters.Add("@coverImage", entity.CoverImage);
            _dynamicParameters.Add("@city", entity.City);
            _dynamicParameters.Add("@district", entity.District);
            _dynamicParameters.Add("@address", entity.Address);
            _dynamicParameters.Add("@description", entity.Description);
            _dynamicParameters.Add("@type", entity.Type);
            _dynamicParameters.Add("@categoryId", entity.CategoryId);
            _dynamicParameters.Add("@employeeId", entity.EmployeeId);
            _dynamicParameters.Add("@id", entity.Id);
            await _connection.ExecuteAsync(query, _dynamicParameters);
        }
    }
}
