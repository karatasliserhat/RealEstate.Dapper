using RealEstate.Dapper.Shared.Abstract.IApiCommandService;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Services.ApiCommandService
{
    public class CategoryCommandApiService : BaseCommandApiService<UpdateCategoryViewModel, CreateCategoryViewModel>, ICategoryCommandApiService
    {
        public CategoryCommandApiService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}
