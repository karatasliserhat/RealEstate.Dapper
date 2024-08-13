using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Abstract.IApiReadService.IProductReadService
{
    public interface IProductReadApiService:IBaseReadApiService<ResultProductViewModel>
    {
        Task<List<ResultProductWithCategoryAndAppUser>> GetListProductWithCategoryAndEmployeeAsync();
        Task<List<ResultProductWithCategoryAndAppUser>> GetListLastProductAsync(int HowProductCount);
        Task<List<ResultProductWithCategoryAndAppUser>> GetListLastProductAsync(int HowProductCount,int UserId);
        Task<List<ResultProductWithCategoryAndAppUser>> GetListProductByUserAsync(int UserId,bool status);
    }
}
