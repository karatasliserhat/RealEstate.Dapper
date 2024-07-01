using Dapper;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;
using System.Data;
using System.Linq.Expressions;

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

        public Task CreateAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }


        public Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<GetListProductWithCategoryAndEmployeeQueryResult>> GetListProductWithEmployeeAndCategory()
        {
            var query = "Select Products.Id,Products.Title,Products.Price,Products.CoverImage,Products.City,Products.District,Products.Address,Products.Type,CategoryName,EmployeeName From Products inner join Categories on Products.CategoryId=Categories.Id inner join Employees on Products.EmployeeId=Employees.Id";
            var values = await _connection.QueryAsync<GetListProductWithCategoryAndEmployeeQueryResult>(query);
            return values.ToList();
        }

        public Task UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
