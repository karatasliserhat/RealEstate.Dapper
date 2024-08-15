using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Abstract.IApiReadService
{
    public interface IEstateAgentDashboardReadApiService { 
        public Task<GetProductCountByEmployeeIdViewModel> GetProductCountByEmployeeId(int userId);
        Task<GetProductCountByStatusFalseViewModel> GetProductCountByStatusFalse(int userId);
        Task<GetProductCountByStatusTrueViewModel> GetProductCountByStatusTrue(int userId);
        Task<List<ResultCityCountViewModel>> ResultCityCount();
    }
}