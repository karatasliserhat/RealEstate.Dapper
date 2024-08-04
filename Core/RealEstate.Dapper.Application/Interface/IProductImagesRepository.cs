using RealEstate.Dapper.Application.Features.MediatR.Results;

namespace RealEstate.Dapper.Application.Interface
{
    public interface IProductImagesRepository
    {
        public Task<List<GetProductImageQueryResult>> GetProductImageListByProductId(int productId);
    }
}
