using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Abstract.IApiReadService
{
    public interface IProductImageReadApiService:IBaseReadApiService<ResultProductImageViewModel>
    {
       Task<List<ResultProductImageViewModel>> GetProductImageListByProductIdAsync(int productId);
    }
}
