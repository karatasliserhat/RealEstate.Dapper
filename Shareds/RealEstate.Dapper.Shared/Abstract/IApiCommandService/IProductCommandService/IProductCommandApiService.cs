using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Abstract.IApiCommandService
{
    public interface IProductCommandApiService:IBaseCommandApiService<UpdateProductViewModel,CreateProductViewModel>
    {
    }
}
