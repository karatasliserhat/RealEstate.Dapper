using Dapper;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;
using System.Data;

namespace RealEstate.Dapper.Persistence.Repositories
{
    public class PopulerLocationRepository : IPopulerLocationRepository
    {
        private readonly IDbConnection _connection;

        public PopulerLocationRepository(IDbConnection connection)
        {
            _dynamicParameters = new DynamicParameters();
            _connection = connection;
        }

        private readonly DynamicParameters _dynamicParameters;
        public async Task CreateAsync(PopulerLocation entity)
        {
            var query = "Insert Into PopulerLocations (CityName,ImageUrl,Status) Values(@cityName, @imageUrl, @status)";
            _dynamicParameters.Add("@cityName", entity.CityName);
            _dynamicParameters.Add("@imageUrl", entity.ImageUrl);
            _dynamicParameters.Add("@status", entity.Status);

            await _connection.ExecuteAsync(query, _dynamicParameters);
        }

        public async Task DeleteAsync(int id)
        {
            await _connection.ExecuteAsync($"Delete From PopulerLocations Where Id={id}");
        }

        public async Task<PopulerLocation> GetByIdAsync(int id)
        {
            var values = await _connection.QueryAsync<PopulerLocation>($"Select * From PopulerLocations Where Id={id}");
            return values.FirstOrDefault();
        }

        public async Task<List<PopulerLocation>> GetListAsync()
        {
            var values = await _connection.QueryAsync<PopulerLocation>($"Select * From PopulerLocations");
            return values.ToList();
        }

        public async Task UpdateAsync(PopulerLocation entity)
        {
            var query = "Update PopulerLocations Set CityName=@cityName, ImageUrl=@imageUrl, Status=@status where Id=@id";
            _dynamicParameters.Add("@id", entity.Id);
            _dynamicParameters.Add("@cityName", entity.CityName);
            _dynamicParameters.Add("@imageUrl", entity.ImageUrl);
            _dynamicParameters.Add("@status", entity.Status);
            await _connection.ExecuteAsync(query, _dynamicParameters);
        }
    }
}
