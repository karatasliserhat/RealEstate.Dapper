namespace RealEstate.Dapper.Shared.Abstract.IApiReadService
{
    public interface IStatisticsReadApiService<ResultViewModel> where ResultViewModel :class 
    {
        Task<ResultViewModel> GetStatisticResult(string ActionName);
    }
}
