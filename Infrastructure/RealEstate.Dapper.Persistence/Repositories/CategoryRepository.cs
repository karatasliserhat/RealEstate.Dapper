using Dapper;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;
using System.Data;
using System.Linq.Expressions;

namespace RealEstate.Dapper.Persistence.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IDbConnection _connection;
        private readonly DynamicParameters _dynamicParameters;
        public CategoryRepository(IDbConnection connection)
        {
            _dynamicParameters = new DynamicParameters();
            _connection = connection;
        }

        public async Task CreateAsync(Category entity)
        {
            var query = "insert into Categories (CategoryName,Status) values(@name,@status)";
            _dynamicParameters.Add("@name", entity.CategoryName);
            _dynamicParameters.Add("@status", entity.Status);

            await _connection.ExecuteAsync(query, _dynamicParameters);
        }

        public async Task DeleteAsync(int id)
        {
            var query = "Delete From Categories where Id=@id";
            _dynamicParameters.Add("@id", id);
            await _connection.ExecuteAsync(query, _dynamicParameters);
        }

        public async Task<Category> GetByFilterAsync(Expression<Func<Category, bool>> filter)
        {
            var query = "Select * From Categories @filter";
            _dynamicParameters.Add("@filter", filter);
            return await _connection.QueryFirstOrDefaultAsync<Category>(query,_dynamicParameters);
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            var query = "Select * From Categories where Id=@id";
            _dynamicParameters.Add("@id", id);
            return await _connection.QueryFirstOrDefaultAsync<Category>(query, _dynamicParameters);
        }

        public async Task<List<Category>> GetListAsync()
        {
            var query = "Select * From Categories";
            var result= await _connection.QueryAsync<Category>(query);

            return result.ToList();
        }

        public async Task UpdateAsync(Category entity)
        {
            var query = "Update Categories Set CategoryName=@name, Status=@status where Id=@id";
            _dynamicParameters.Add("@name", entity.CategoryName);
            _dynamicParameters.Add("@status", entity.Status);
            _dynamicParameters.Add("@id", entity.Id);

            await _connection.ExecuteAsync(query, _dynamicParameters);

        }
    }
}
