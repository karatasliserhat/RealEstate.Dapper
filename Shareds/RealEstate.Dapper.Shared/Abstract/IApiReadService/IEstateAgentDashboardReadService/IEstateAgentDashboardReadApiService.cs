namespace RealEstate.Dapper.Shared.Abstract.IApiReadService
{
    public interface IEstateAgentDashboardReadApiService<GetResultViewCountModel> where GetResultViewCountModel : class
    {
        public Task<GetResultViewCountModel> GetResultViewCount(string Action, int id);
        public Task<GetResultViewCountModel> GetResultViewCount(string Action);
    }
}
