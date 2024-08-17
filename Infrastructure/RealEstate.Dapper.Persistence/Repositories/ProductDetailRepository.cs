using Dapper;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;
using System.Data;

namespace RealEstate.Dapper.Persistence.Repositories
{
    public class ProductDetailRepository : IProductDetailRepository
    {
        private readonly IDbConnection _dbConnection;

        public ProductDetailRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<GetProductAndDetailByProductIdQueryResult> GetProductAndDetailByProductIdAsync(int productId)
        {
            var query = ($"Select Products.Id,Products.Title, Products.SlugUrl,Products.Price,Products.CoverImage,Products.City,Products.District,Products.Address,Products.Type,Products.Description,Products.CreatedDate,CategoryName,Name,Products.AppUserId,ProductDetails.Size,ProductDetails.BedRoomCount,ProductDetails.RoomCount,ProductDetails.GarageSize,ProductDetails.BuildYear,ProductDetails.Location,ProductDetails.VideoUrl From Products inner join Categories on Products.CategoryId=Categories.Id inner join AppUsers on Products.AppUserId=AppUsers.UserId inner join ProductDetails on Products.Id=ProductDetails.ProductId where Products.Id={productId} Order By Products.Id Desc");
            var values = await _dbConnection.QueryFirstAsync<GetProductAndDetailByProductIdQueryResult>(query);
            return values;
        }

        public async Task<List<GetProductAndDetailListQueryResult>> GetProductAndDetailListAsync()
        {
            var query = ($"Select Products.Id,Products.Title,Products.SlugUrl,Products.Price,Products.CoverImage,Products.City,Products.District,Products.Address,Products.Type,CategoryName,Name,ProductDetails.Size,ProductDetails.BedRoomCount,ProductDetails.RoomCount,ProductDetails.GarageSize,ProductDetails.BuildYear,ProductDetails.Location,ProductDetails.VideoUrl From Products inner join Categories on Products.CategoryId=Categories.Id inner join AppUsers on Products.AppUserId=AppUsers.UserId inner join ProductDetails on Products.Id=ProductDetails.ProductId where Products.Status=1 Order By Products.Id Desc");
            var values = await _dbConnection.QueryAsync<GetProductAndDetailListQueryResult>(query);
            return values.ToList();
        }
    }
}
