using Dapper;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;
using System.Data;

namespace RealEstate.Dapper.Persistence.Repositories
{
    public class ProperyAmenityRepository : IProperyAmenityRepository
    {
        private readonly IDbConnection _connection;

        public ProperyAmenityRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<List<GetPropertyAmenityByProductIdQueryResult>> GetPropertyAmenityByProductIdAsync(int productId)
        {
            var query = $"Select ProductId, AmenityId, title,status From PropertyAmenities  inner join Amenities on PropertyAmenities.AmenityId=Amenities.Id Where PropertyAmenities.ProductId={productId}";
            var values = await _connection.QueryAsync<GetPropertyAmenityByProductIdQueryResult>(query);
            return values.ToList();
        }

        public async Task<List<GetPropertyAmenityByProductIdStatusFalseQueryResult>> GetPropertyAmenityByProductIdStatusFalseAsync(int productId)
        {
            var query = $"Select ProductId, AmenityId,title,status From PropertyAmenities  inner join Amenities on PropertyAmenities.AmenityId=Amenities.Id Where PropertyAmenities.ProductId={productId} and Status=0";
            var values = await _connection.QueryAsync<GetPropertyAmenityByProductIdStatusFalseQueryResult>(query);
            return values.ToList();
        }

        public async Task<List<GetPropertyAmenityByProductIdStatusTrueQueryResult>> GetPropertyAmenityByProductIdStatusTrueAsync(int productId)
        {
            var query = $"Select ProductId, AmenityId,title,status From PropertyAmenities  inner join Amenities on PropertyAmenities.AmenityId=Amenities.Id Where PropertyAmenities.ProductId={productId} and Status=1";
            var values = await _connection.QueryAsync<GetPropertyAmenityByProductIdStatusTrueQueryResult>(query);
            return values.ToList();
        }
    }
}
