namespace RealEstate.Dapper.Shared.Abstract.IApiReadService
{
    public interface IBaseReadApiService<ResultViewModel> where ResultViewModel : class
    {
        Task<ResultViewModel> GetByIdAsync(int id);
        Task<ResultViewModel> GetByIdAsync(string id);
        Task<List<ResultViewModel>> GetListAsync();
        Task<List<ResultViewModel>> GetListAsync(string actionName);
    }
}
