using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Interface
{
    public interface IAppUserRepository
    {
        Task<List<GetAppUserQueryResult>> GetAppUserListAsync();
        Task<GetAppUserByIdQueryResult> GetAppUserByIdAsync(int id);
    }
}
