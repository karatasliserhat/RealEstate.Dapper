using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Interface
{
    public interface IProductDetailRepository
    {
        Task<List<GetProductAndDetailListQueryResult>> GetProductAndDetailListAsync();
        Task<GetProductAndDetailByProductIdQueryResult> GetProductAndDetailByProductIdAsync(int productId);
    }
}
