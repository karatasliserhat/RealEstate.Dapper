using Dapper;
using RealEstate.Dapper.Application.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Dapper.Persistence.Repositories
{
    public class EstateAgentDashboardRepository : IEstateAgentDashboardRepository
    {
        private readonly IDbConnection _connection;

        public EstateAgentDashboardRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<int> ProductCountByEmployeeIdAsync(int id)
        {
            var query = $"Select * From Products Where EmployeeId={id}";
            var values = await _connection.QueryAsync<int>(query);
            return values.Count();
        }

        public async Task<int> ProductCountByStatusFalseAsync(int id)
        {
            var query = $"Select * From Products Where Status=0 and EmployeeId={id}";
            var values = await _connection.QueryAsync<int>(query);
            return values.Count();
        }

        public async Task<int> ProductCountByStatusTrueAsync(int id)
        {
            var query = $"Select * From Products Where Status=1 and EmployeeId={id}";
            var values = await _connection.QueryAsync<int>(query);
            return values.Count();
        }
    }
}
