using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Model;

namespace RealEstate.Dapper.Application.Interface
{
    public interface IAccountRepository
    {
        Task<LoginUserQueryResult> LoginAsync(LoginUserModel loginUserModel);
    }
}
