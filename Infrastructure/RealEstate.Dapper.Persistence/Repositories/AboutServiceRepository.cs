using Dapper;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;
using System.Data;

namespace RealEstate.Dapper.Persistence.Repositories
{
    public class AboutServiceRepository : IAboutServiceRepository
    {
        private readonly IDbConnection _connection;
        private readonly DynamicParameters _dynamicParameters;
        public AboutServiceRepository(IDbConnection connection)
        {
            _dynamicParameters = new DynamicParameters();
            _connection = connection;
        }

        public async Task CreateAsync(AboutService entity)
        {
            var query = "Insert Into AboutServices (AboutServiceName,AboutServiceStatus) Values(@aboutServiceName,@aboutServiceStatus)";
            _dynamicParameters.Add("@aboutServiceName", entity.AboutServiceName);
            _dynamicParameters.Add("@aboutServiceStatus", true);

            await _connection.ExecuteAsync(query, _dynamicParameters);
        }

        public async Task DeleteAsync(int id)
        {
            var query = "delete from AboutServices where Id=@id";
            _dynamicParameters.Add("@id", id);
            await _connection.ExecuteAsync(query, _dynamicParameters);
        }

        public async Task<AboutService> GetByIdAsync(int id)
        {
            var query = "Select * from AboutServices Where Id=@id";
            _dynamicParameters.Add("@id", id);

            var value = await _connection.QueryAsync<AboutService>(query, _dynamicParameters);
            return value.FirstOrDefault();
        }
        public async Task<List<AboutService>> GetListAsync()
        {
            var query = "Select * From AboutServices";
            var values = await _connection.QueryAsync<AboutService>(query);
            return values.ToList();
        }

        public async Task UpdateAsync(AboutService entity)
        {
            var query = "Update AboutServices Set AboutServiceName=@aboutServiceName,AboutServiceStatus=@aboutServiceStatus where Id=@id";
            _dynamicParameters.Add("@id", entity.Id);
            _dynamicParameters.Add("@aboutServiceName", entity.AboutServiceName);
            _dynamicParameters.Add("@aboutServiceStatus", entity.AboutServiceStatus);

            await _connection.ExecuteAsync(query, _dynamicParameters);

        }
    }
}
