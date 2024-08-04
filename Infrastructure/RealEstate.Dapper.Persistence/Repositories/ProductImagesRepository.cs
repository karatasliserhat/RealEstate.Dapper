using Dapper;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;
using System.Data;
using System.Data.Common;

namespace RealEstate.Dapper.Persistence.Repositories
{
    public class ProductImagesRepository : IProductImagesRepository
    {
        private readonly IDbConnection _connection;

        public ProductImagesRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<List<GetProductImageQueryResult>> GetProductImageListByProductId(int productId)
        {
            var query = $"Select ProductImages.Id, ProductImages.ProductId, ProductImages.ImageUrl from ProductImages inner join Products on ProductImages.ProductId=Products.Id where Products.Id={productId} Order By Products.Id Desc";
            var values = await _connection.QueryAsync<GetProductImageQueryResult>(query);
            return values.ToList();
        }
    }
}
