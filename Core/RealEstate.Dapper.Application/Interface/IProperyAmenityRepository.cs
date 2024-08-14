using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Interface
{
    public interface IProperyAmenityRepository
    {
        Task<List<GetPropertyAmenityByProductIdQueryResult>> GetPropertyAmenityByProductIdAsync(int productId);
        Task<List<GetPropertyAmenityByProductIdStatusFalseQueryResult>> GetPropertyAmenityByProductIdStatusFalseAsync(int productId);
        Task<List<GetPropertyAmenityByProductIdStatusTrueQueryResult>> GetPropertyAmenityByProductIdStatusTrueAsync(int productId);
    }
}
