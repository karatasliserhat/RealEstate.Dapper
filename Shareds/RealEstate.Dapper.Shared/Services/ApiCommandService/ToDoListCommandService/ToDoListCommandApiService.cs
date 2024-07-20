using RealEstate.Dapper.Shared.Abstract.IApiCommandService;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Services.ApiCommandService
{
    public class ToDoListCommandApiService : BaseCommandApiService<UpdateToDoListViewModel, CreateToDoListViewModel>, IToDoListCommandApiService
    {
        public ToDoListCommandApiService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}
