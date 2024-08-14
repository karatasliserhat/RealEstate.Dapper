using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Abstract.IApiReadService
{
    public interface IPropertyAmenityReadApiService
    {
        Task<List<ResultPropertyAmenityByProductIdViewModel>> GetPropertyAmenityByProductId(int ProductId);
        Task<List<ResultPropertyAmenityByProductIdStatusTrueViewModel>> GetPropertyAmenityByProductIdStatusTrue(int ProductId);
        Task<List<ResultPropertyAmenityByProductIdStatusFalseViewModel>> GetPropertyAmenityByProductIdStatusFalse(int ProductId);
    }
}
