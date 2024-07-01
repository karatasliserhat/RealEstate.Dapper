using Dapper;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;
using System.Data;

namespace RealEstate.Dapper.Persistence.Repositories
{
    public class AboutDetailRepository : IAboutDetailRepository
    {
        private readonly IDbConnection _connection;
        private readonly DynamicParameters _dynamicParameters;
        public AboutDetailRepository(IDbConnection connection)
        {
            _dynamicParameters = new DynamicParameters();
            _connection = connection;
        }

        public async Task CreateAsync(AboutDetail entity)
        {
            var query = "insert into AboutDetails (Title,SubTitle,Description,Description2) values(@title,@subTitle,@description,@description2)";
            _dynamicParameters.Add("@title", entity.Title);
            _dynamicParameters.Add("@subTitle", entity.SubTitle);
            _dynamicParameters.Add("@description", entity.Description);
            _dynamicParameters.Add("@description2", entity.Description2);

            await _connection.ExecuteAsync(query, _dynamicParameters);
        }

        public async Task DeleteAsync(int id)
        {
            var query = "Delete From AboutDetails where Id=@id";
            _dynamicParameters.Add("@id", id);
            await _connection.ExecuteAsync(query, _dynamicParameters);
        }


        public async Task<AboutDetail> GetByIdAsync(int id)
        {
            var query = "Select * From AboutDetails where Id=@id";
            _dynamicParameters.Add("@id", id);
            var value = await _connection.QueryAsync<AboutDetail>(query, _dynamicParameters);
            return value.FirstOrDefault();
        }

        public async Task<List<AboutDetail>> GetListAsync()
        {
            var query = "Select * From AboutDetails";
            var value = await _connection.QueryAsync<AboutDetail>(query);
            return value.ToList();
        }

        public async Task UpdateAsync(AboutDetail entity)
        {
            var query = "Update AboutDetails Set Title=@title,SubTitle=@subTitle,Description=@description,Description2=@description2 where Id=@id";
            _dynamicParameters.Add("@Id", entity.Id);
            _dynamicParameters.Add("@title", entity.Title);
            _dynamicParameters.Add("@subTitle", entity.SubTitle);
            _dynamicParameters.Add("@description", entity.Description);
            _dynamicParameters.Add("@description2", entity.Description2);
            await _connection.ExecuteAsync(query, _dynamicParameters);
        }
    }
}
