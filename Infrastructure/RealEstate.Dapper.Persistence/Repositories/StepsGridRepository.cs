using Dapper;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;
using System.Data;

namespace RealEstate.Dapper.Persistence.Repositories
{
    public class StepsGridRepository : IStepsGridRepository
    {
        private readonly IDbConnection _connection;
        private readonly DynamicParameters _dynamicParameters;

        public StepsGridRepository(IDbConnection connection)
        {
            _dynamicParameters = new DynamicParameters();
            _connection = connection;
        }

        public async Task CreateAsync(StepsGrid entity)
        {
            var query = "Insert Into StepsGrids (IconUrl,Title,Descripiton,Status) Values(@iconUrl,@title,@description,@status)";
            _dynamicParameters.Add("iconUrl", entity.IconUrl);
            _dynamicParameters.Add("title", entity.Title);
            _dynamicParameters.Add("description", entity.Descripiton);
            _dynamicParameters.Add("status", entity.Status);
            await _connection.ExecuteAsync(query, _dynamicParameters);
        }

        public async Task DeleteAsync(int id)
        {
            await _connection.ExecuteAsync($"delete from StepsGrids where Id={id}");
        }

        public async Task<StepsGrid> GetByIdAsync(int id)
        {
            var value = await _connection.QueryAsync<StepsGrid>($"Select * from StepsGrids where Id={id}");
            return value.FirstOrDefault();
        }

        public async Task<List<StepsGrid>> GetListAsync()
        {
            var values = await _connection.QueryAsync<StepsGrid>("Select * from StepsGrids");
            return values.ToList();
        }

        public async Task UpdateAsync(StepsGrid entity)
        {
            var query = "Update StepsGrids Set IconUrl=@iconUrl,Title=@title,Descripiton=@description,Status=@status Where Id=@id";
            _dynamicParameters.Add("iconUrl", entity.IconUrl);
            _dynamicParameters.Add("title", entity.Title);
            _dynamicParameters.Add("description", entity.Descripiton);
            _dynamicParameters.Add("status", entity.Status);
            _dynamicParameters.Add("id", entity.Id);
            await _connection.ExecuteAsync(query, _dynamicParameters);
        }
    }
}
