using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Services.ApiReadService
{
    public class EmployeeReadApiService : BaseReadApiService<ResultEmployeeViewModel>, IEmployeeReadApiService
    {
        public EmployeeReadApiService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}
