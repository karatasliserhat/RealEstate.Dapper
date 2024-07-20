using Dapper;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;
using System.Data;

namespace RealEstate.Dapper.Persistence.Repositories
{
    public class ToDolistRepository : IToDoListRepository
    {
        private readonly IDbConnection _connection;
        private readonly DynamicParameters _dynamicParameters;

        public ToDolistRepository(IDbConnection connection)
        {
            _dynamicParameters = new DynamicParameters();
            _connection = connection;
        }

        public async Task CreateAsync(ToDoList entity)
        {
            var query = "Insert Into ToDoLists(Description, Status) Values(@description, @status)";
            _dynamicParameters.Add("@description", entity.Description);
            _dynamicParameters.Add("@status", true);
            await _connection.ExecuteAsync(query, _dynamicParameters);
        }

        public async Task DeleteAsync(int id)
        {
            var query = $"Delete From ToDoLists Where Id={id}";
            await _connection.ExecuteAsync(query);
        }

        public async Task<ToDoList> GetByIdAsync(int id)
        {
            var query = $"Select * From ToDoLists Where Id={id}";
            var values = await _connection.QueryAsync<ToDoList>(query);
            return values.FirstOrDefault();
        }

        public async Task<List<ToDoList>> GetListAsync()
        {
            var query = $"Select * From ToDoLists";
            var values = await _connection.QueryAsync<ToDoList>(query);
            return values.ToList();
        }

        public async Task UpdateAsync(ToDoList entity)
        {
            var query = "Update ToDoLists Set Description=@description, Status=@status Where Id=@id";
            _dynamicParameters.Add("@description", entity.Description);
            _dynamicParameters.Add("@status", entity.Status);
            _dynamicParameters.Add("@id", entity.Id);
            await _connection.ExecuteAsync(query, _dynamicParameters);
        }
    }
}
