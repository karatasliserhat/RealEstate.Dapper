using Dapper;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;
using System.Data;

namespace RealEstate.Dapper.Persistence.Repositories
{
    public class EstateAgentDashboardRepository : IEstateAgentDashboardRepository
    {
        private readonly IDbConnection _connection;

        public EstateAgentDashboardRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<List<GetLastFiveCityCountQueryResult>> GetLastFiveCountCity()
        {
            var query = "Select City, Count(*) as 'CityCount' From Products Group By City Order By CityCount Desc";
            var values = await _connection.QueryAsync<GetLastFiveCityCountQueryResult>(query);
            return values.ToList();
        }

        public async Task<int> ProductCountByEmployeeIdAsync(int id)
        {
            var query = $"Select * From Products Where AppUserId={id}";
            var values = await _connection.QueryAsync<int>(query);
            return values.Count();
        }

        public async Task<int> ProductCountByStatusFalseAsync(int id)
        {
            var query = $"Select * From Products Where Status=0 and AppUserId={id}";
            var values = await _connection.QueryAsync<int>(query);
            return values.Count();
        }

        public async Task<int> ProductCountByStatusTrueAsync(int id)
        {
            var query = $"Select * From Products Where Status=1 and AppUserId={id}";
            var values = await _connection.QueryAsync<int>(query);
            return values.Count();
        }
    }
}
