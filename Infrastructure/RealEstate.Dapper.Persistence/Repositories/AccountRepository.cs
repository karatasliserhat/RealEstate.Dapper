using Dapper;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Application.Model;
using System.Data;

namespace RealEstate.Dapper.Persistence.Repositories
{

    public class AccountRepository : IAccountRepository
    {
        private readonly IDbConnection _connection;
        private readonly DynamicParameters _dynamicParameters;
        public AccountRepository(IDbConnection connection)
        {
            _dynamicParameters = new DynamicParameters();
            _connection = connection;
        }

        public async Task<LoginUserQueryResult> LoginAsync(LoginUserModel loginUserModel)
        {
            var query = $"Select * From AppUsers Where UserName=@userName and Password=@password";
            _dynamicParameters.Add("@userName", loginUserModel.UserName);
            _dynamicParameters.Add("@password", loginUserModel.Password);
            var result = await _connection.QueryFirstOrDefaultAsync<LoginUserQueryResult>(query, _dynamicParameters);
            if (result is not null)
            {
                var query2 = $"Select * From AppRoles Where RoleId={result.RoleId}";
                var result2 = await _connection.QueryFirstOrDefaultAsync<LoginUserQueryResult>(query2);
                result.RoleName = result2.RoleName;
                result.IsExist = true;
                return result;
            }

            return null;
        }
    }
}
