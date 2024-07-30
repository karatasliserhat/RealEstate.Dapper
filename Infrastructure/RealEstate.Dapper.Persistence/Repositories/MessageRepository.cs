using Dapper;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;
using System.Data;

namespace RealEstate.Dapper.Persistence.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly IDbConnection _dbConnection;

        public MessageRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<List<GetInBoxMessageQueryResult>> GetInBoxMessage(int ReceiveId, int HowCount)
        {
            var query = $"Select Top({HowCount}) AppUsers.Name, AppUsers.ImageUrl,Messages.Subject,Messages.Id,Messages.Detail,Messages.SendDate,Messages.IsRead From Messages Inner Join AppUsers on Messages.Sender=AppUsers.UserId where Messages.Receive={ReceiveId} Order By Id Desc";
            var values = await _dbConnection.QueryAsync<GetInBoxMessageQueryResult>(query);
            return values.ToList();
        }
    }
}
