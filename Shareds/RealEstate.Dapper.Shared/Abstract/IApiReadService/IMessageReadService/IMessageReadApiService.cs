using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Abstract.IApiReadService
{
    public interface IMessageReadApiService
    {
        Task<List<ResultInBoxMessage>> GetInBoxMessageListAsync(int ReceiveId, int HowMessageCount);
    }
}
