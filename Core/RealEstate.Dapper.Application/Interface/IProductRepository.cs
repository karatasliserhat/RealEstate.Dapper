using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Domain.Entities;

namespace RealEstate.Dapper.Application.Interface
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<GetListProductWithCategoryAndAppUserQueryResult>> GetListProductWithAppUserAndCategory();
        Task<GetProductByIdWithCategoryAndAppUserQueryResult> GetByIdWithCategoryAndAppUserAsync(int id);

        Task<List<GetListProductWithCategoryAndAppUserQueryResult>> GetListLastProductAsync(int HowProductCount);
        Task<List<GetListProductWithCategoryAndAppUserQueryResult>> GetListLastProductAsync(int HowProductCount, int UserId);
        Task DealOfTheDayTrue(int id);
        Task DealOfTheDayFalse(int id);

        Task<List<GetListProductByUserQueryResult>> GetListProductByUserAndTrueOrFalseAsync(int AppUserId, bool status);
        Task<List<GetListProductWithCategoryAndAppUserQueryResult>> GetProductBySearchList(string SearchKeyValue, int CategoryId, string City);
    }
}
