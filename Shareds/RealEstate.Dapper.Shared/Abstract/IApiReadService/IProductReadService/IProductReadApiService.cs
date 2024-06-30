using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Abstract.IApiReadService.IProductReadService
{
    public interface IProductReadApiService:IBaseReadApiService<ResultProductViewModel>
    {
        Task<List<ResultProductWithCategoryAndEmployee>> GetListProductWithCategoryAndEmployeeAsync();
    }
}
