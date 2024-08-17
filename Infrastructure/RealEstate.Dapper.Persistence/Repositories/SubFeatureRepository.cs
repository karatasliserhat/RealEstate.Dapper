using Dapper;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;
using System.Data;

namespace RealEstate.Dapper.Persistence.Repositories
{
    public class SubFeatureRepository : ISubFeatureRepository
    {
        private readonly IDbConnection _connection;

        public SubFeatureRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<GetByIdSubFeatureQueryResults> GetByIdSubFeatureQueryAsync(int id)
        {
            var qeuery = $"Select * From SubFeatures where Id={id}";
            return await _connection.QueryFirstOrDefaultAsync<GetByIdSubFeatureQueryResults>(qeuery);
        }

        public async Task<List<GetSubFeatureQueryResults>> GetSubFeatureListAsync()
        {
            var query = "Select * From SubFeatures";
            var values = await _connection.QueryAsync<GetSubFeatureQueryResults>(query);
            return values.ToList();
        }
    }
}
