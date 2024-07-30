using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Interface
{
    public interface IMessageRepository
    {
        Task<List<GetInBoxMessageQueryResult>> GetInBoxMessage(int ReceiveId, int HowCount);
    }
}
