using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Domain.Entities;

namespace RealEstate.Dapper.Application.Interface
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        Task<List<GetListProductWithCategoryAndEmployeeQueryResult>> GetListProductWithEmployeeAndCategory();
        Task<GetProductByIdWithCategoryAndEmployeeQueryResult> GetByIdWithCategoryAndEmployeeAsync(int id);

        Task<List<GetListProductWithCategoryAndEmployeeQueryResult>> GetListLastProductAsync(int HowProductCount);
        Task<List<GetListProductWithCategoryAndEmployeeQueryResult>> GetListLastProductAsync(int HowProductCount, int UserId);
        Task DealOfTheDayTrue(int id);
        Task DealOfTheDayFalse(int id);

        Task<List<GetListProductByUserQueryResult>> GetListProductByUserAsync(int employeeId);
    }
}
