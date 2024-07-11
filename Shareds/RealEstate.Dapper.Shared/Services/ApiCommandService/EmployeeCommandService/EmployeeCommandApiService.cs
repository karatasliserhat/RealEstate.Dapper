using RealEstate.Dapper.Shared.Abstract.IApiCommandService;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Services.ApiCommandService
{
    public class EmployeeCommandApiService : BaseCommandApiService<UpdateEmployeeViewModel, CreateEmployeeViewModel>, IEmployeeCommandApiService
    {
        public EmployeeCommandApiService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}
