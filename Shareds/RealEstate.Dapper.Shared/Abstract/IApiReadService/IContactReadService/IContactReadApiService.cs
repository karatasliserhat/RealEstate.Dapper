using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Abstract.IApiReadService
{
    public interface IContactReadApiService : IBaseReadApiService<ResultContactViewModel>
    {
        Task<List<ResultContactViewModel>> GetLastContactsAsync(int HowContactCount);
    }
}
