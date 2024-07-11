using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.Shared.Services.ApiReadService
{
    public class CategoryReadApiService : BaseReadApiService<ResultCategoryViewModel>, ICategoryReadApiService
    {
        public CategoryReadApiService(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}
