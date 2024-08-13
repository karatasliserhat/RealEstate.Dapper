using Dapper;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;
using System.Data;

namespace RealEstate.Dapper.Persistence.Repositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly IDbConnection _dbConnection;

        public AppUserRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<GetAppUserByIdQueryResult> GetAppUserByIdAsync(int id)
        {
            var query = $"Select * From AppUsers Where UserId={id}";
            return await _dbConnection.QueryFirstOrDefaultAsync<GetAppUserByIdQueryResult>(query);
    
        }

        public async Task<List<GetAppUserQueryResult>> GetAppUserListAsync()
        {
            var query = $"Select * From AppUsers";
            var values= await _dbConnection.QueryAsync<GetAppUserQueryResult>(query);

            return values.ToList();
        }
    }
}
