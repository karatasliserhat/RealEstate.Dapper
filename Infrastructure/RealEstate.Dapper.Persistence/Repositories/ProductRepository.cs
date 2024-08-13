using Dapper;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;
using System.Data;

namespace RealEstate.Dapper.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;
        private readonly DynamicParameters _dynamicParameters;

        public ProductRepository(IDbConnection connection)
        {
            _connection = connection;
            _dynamicParameters = new DynamicParameters();
        }

        public async Task CreateAsync(Product entity)
        {
            var query = "Insert Into Products (Title,Price,CoverImage,City,District,Address,Description,Type,CategoryId,AppUserId,DealOfTheDay,CreatedDate, Status) Values(@title,@price,@coverImage,@city,@district,@address,@description,@type,@categoryId,@appUserId,@dealOfTheDay,@createdDate,@status)";
            _dynamicParameters.Add("@title", entity.Title);
            _dynamicParameters.Add("@price", entity.Price);
            _dynamicParameters.Add("@coverImage", entity.CoverImage);
            _dynamicParameters.Add("@city", entity.City);
            _dynamicParameters.Add("@district", entity.District);
            _dynamicParameters.Add("@address", entity.Address);
            _dynamicParameters.Add("@description", entity.Description);
            _dynamicParameters.Add("@type", entity.Type);
            _dynamicParameters.Add("@categoryId", entity.CategoryId);
            _dynamicParameters.Add("@appUserId", entity.AppUserId);
            _dynamicParameters.Add("@dealOfTheDay", entity.DealOfTheDay);
            _dynamicParameters.Add("@createdDate", entity.CreatedDate);
            _dynamicParameters.Add("@status", true);
            await _connection.ExecuteAsync(query, _dynamicParameters);
        }

        public async Task DealOfTheDayFalse(int id)
        {
            var query = ("Update Products Set DealOfTheDay=0 Where Id=@id");
            _dynamicParameters.Add("@id", id);
            await _connection.ExecuteAsync(query, _dynamicParameters);
        }

        public async Task DealOfTheDayTrue(int id)
        {
            var query = ("Update Products Set DealOfTheDay=1 Where Id=@id");
            _dynamicParameters.Add("@id", id);
            await _connection.ExecuteAsync(query, _dynamicParameters);
        }

        public async Task DeleteAsync(int id)
        {
            var query = $"Delete From Products Where Id={id}";
            await _connection.ExecuteAsync(query);
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            var query = $"Select * From Products Where Id={id}";
            var values = await _connection.QueryAsync<Product>(query);
            return values.FirstOrDefault();
        }

        public async Task<GetProductByIdWithCategoryAndAppUserQueryResult> GetByIdWithCategoryAndAppUserAsync(int id)
        {
            var query = $"Select Products.Id,Products.Title,Products.Price,Products.CoverImage,Products.City,Products.District,Products.Address,Products.Type,Products.DealOfTheDay, Products.CreatedDate,CategoryName,Name From Products Inner Join Categories on Products.CategoryId=Categories.Id Inner Join AppUsers on Products.AppUserId=AppUsers.UserId where Products.Id={id}";
            var values = await _connection.QueryAsync<GetProductByIdWithCategoryAndAppUserQueryResult>(query, _dynamicParameters);
            return values.FirstOrDefault();


        }

        public async Task<List<Product>> GetListAsync()
        {
            var query = "Select * From Products";
            var values = await _connection.QueryAsync<Product>(query);
            return values.ToList();
        }

        public async Task<List<GetListProductWithCategoryAndAppUserQueryResult>> GetListLastProductAsync(int HowProductCount)
        {
            var query = ($"Select Top({HowProductCount}) Products.Id,Products.Title,Products.Price,Products.CoverImage,Products.City,Products.District,Products.Address,Products.Type,Products.DealOfTheDay,Products.CreatedDate,CategoryName,Name From Products inner join Categories on Products.CategoryId=Categories.Id inner join AppUsers on Products.AppUserId=AppUsers.UserId Order By Products.Id Desc");
            var values = await _connection.QueryAsync<GetListProductWithCategoryAndAppUserQueryResult>(query);
            return values.ToList();
        }

        public async Task<List<GetListProductWithCategoryAndAppUserQueryResult>> GetListLastProductAsync(int HowProductCount, int UserId)
        {
            var query = ($"Select Top({HowProductCount}) Products.Id,Products.Title,Products.Price,Products.CoverImage,Products.City,Products.District,Products.Address,Products.Type,Products.DealOfTheDay,Products.CreatedDate,CategoryName,Name From Products inner join Categories on Products.CategoryId=Categories.Id inner join AppUsers on Products.AppUserId=AppUsers.UserId Where AppUserId={UserId} Order By Products.Id Desc");
            var values = await _connection.QueryAsync<GetListProductWithCategoryAndAppUserQueryResult>(query);
            return values.ToList();
        }

        public async Task<List<GetListProductByUserQueryResult>> GetListProductByUserAndTrueOrFalseAsync(int AppUserId, bool status)
        {
            var status1 = status == true ? 1 : 0;
            var query = $"Select Products.Id,Products.Title,Products.Price,Products.CoverImage,Products.City,Products.District,Products.Address,Products.Type,Products.DealOfTheDay,Products.CreatedDate,Products.Status,CategoryName,Name From Products inner join Categories on Products.CategoryId=Categories.Id inner join AppUsers on Products.AppUserId=AppUsers.UserId Where Products.AppUserId={AppUserId} and Products.Status={status1}";
            var values = await _connection.QueryAsync<GetListProductByUserQueryResult>(query);
            return values.ToList();
        }

        public async Task<List<GetListProductWithCategoryAndAppUserQueryResult>> GetListProductWithAppUserAndCategory()
        {
            var query = "Select Products.Id,Products.Title,Products.Price,Products.CoverImage,Products.City,Products.District,Products.Address,Products.Type,Products.DealOfTheDay,Products.CreatedDate,CategoryName,Name From Products inner join Categories on Products.CategoryId=Categories.Id inner join AppUsers on Products.AppUserId=AppUsers.UserId";
            var values = await _connection.QueryAsync<GetListProductWithCategoryAndAppUserQueryResult>(query);
            return values.ToList();
        }

        public async Task UpdateAsync(Product entity)
        {
            var query = $"Update Products Set Title=@title,Price=@price,CoverImage=@coverImage,City=@city,District=@district,Address=@address,Description=@description,Type=@type,CategoryId=@categoryId,AppUserId=@appUserId, DealOfTheDay=@dealOfTheDay Where Id=@id";

            _dynamicParameters.Add("@title", entity.Title);
            _dynamicParameters.Add("@price", entity.Price);
            _dynamicParameters.Add("@coverImage", entity.CoverImage);
            _dynamicParameters.Add("@city", entity.City);
            _dynamicParameters.Add("@district", entity.District);
            _dynamicParameters.Add("@address", entity.Address);
            _dynamicParameters.Add("@description", entity.Description);
            _dynamicParameters.Add("@type", entity.Type);
            _dynamicParameters.Add("@categoryId", entity.CategoryId);
            _dynamicParameters.Add("@appUserId", entity.AppUserId);
            _dynamicParameters.Add("@dealOfTheDay", entity.DealOfTheDay);
            _dynamicParameters.Add("@id", entity.Id);
            await _connection.ExecuteAsync(query, _dynamicParameters);
        }
    }
}
