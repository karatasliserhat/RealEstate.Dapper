using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Abstract.IApiCommandService
{
    public interface IProductCommandApiService:IBaseCommandApiService<UpdateProductViewModel,CreateProductViewModel>
    {
        Task<HttpResponseMessage> DealOfTheDayTrue(int id);
        Task<HttpResponseMessage> DealOfTheDayFalse(int id);
    }
}
