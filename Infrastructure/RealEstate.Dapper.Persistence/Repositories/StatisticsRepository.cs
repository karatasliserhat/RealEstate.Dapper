using Dapper;
using RealEstate.Dapper.Application.Interface;
using System.Data;

namespace RealEstate.Dapper.Persistence.Repositories
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly IDbConnection _connection;

        public StatisticsRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<int> ActiveCategoryCount()
        {
            var query = "Select Count(*) From Categories where Status=1";

            return await _connection.QueryFirstOrDefaultAsync<int>(query);
        }

        public async Task<int> ActiveEmployeeCount()
        {
            var query = "Select Count(*) From Employees Where Status=1";
            return await _connection.QueryFirstOrDefaultAsync<int>(query);
        }

        public async Task<int> ApartmentCount()
        {
            var query = "Select Count(*) From Products where Title like '%Daire%'";
            return await _connection.QueryFirstOrDefaultAsync<int>(query);
        }

        public async Task<decimal> AvarageProductByRent()
        {
            var query = "Select Avg(Price) From Products Where  Type Like '%Kira%'";
            return await _connection.QueryFirstOrDefaultAsync<decimal>(query);
        }

        public async Task<decimal> AvarageProductBySent()
        {
            var query = "Select Avg(Price) From Products Where  Type Like '%Sat%'";
            return await _connection.QueryFirstOrDefaultAsync<decimal>(query);
        }

        public async Task<int> AvarageRoomCount()
        {
            var query = "Select Avg(RoomCount) From ProductDetails";
            return await _connection.QueryFirstOrDefaultAsync<int>(query);
        }

        public async Task<int> CategoryCount()
        {
            var query = "Select Count(*) From Categories";
            return await _connection.QueryFirstOrDefaultAsync<int>(query);
        }

        public async Task<string> CategoryNameByMaxProductCount()
        {
            var query = "Select Top(1) CategoryName,Count(CategoryName) from Products Inner Join Categories on Products.CategoryId=Categories.Id Group By CategoryName Order by COUNT(CategoryName) desc";
            return await _connection.QueryFirstOrDefaultAsync<string>(query);
        }

        public async Task<string> CityNameByMaxProductCount()
        {
            var query = "Select Top(1) City,Count(City) from products Group By City Order By Count(City) desc";
            return await _connection.QueryFirstOrDefaultAsync<string>(query);
        }

        public async Task<int> DifferentCityCount()
        {
            var query = "Select Count(Distinct(City)) From Products";
            return await _connection.QueryFirstOrDefaultAsync<int>(query);
        }

        public async Task<string> EmployeeNameByMaxProductCount()
        {
            var query = "Select Top(1) EmployeeName,Count(EmployeeId) from Products Inner Join Employees on Products.EmployeeId=Employees.Id Group By EmployeeName";
            return await _connection.QueryFirstOrDefaultAsync<string>(query);
        }

        public async Task<decimal> LastProductPrice()
        {
            var query = "Select Top(1) Price From Products Order By Id desc";
            return await _connection.QueryFirstOrDefaultAsync<decimal>(query);
        }

        public async Task<int> NewestBuildingYear()
        {
            var query = "Select Top(1) BuildYear From ProductDetails Order By BuildYear Desc";
            return await _connection.QueryFirstOrDefaultAsync<int>(query);
        }

        public async Task<int> OldestBuildingYear()
        {
            var query = "Select Top(1) BuildYear From ProductDetails Order By BuildYear";
            return await _connection.QueryFirstOrDefaultAsync<int>(query);
        }

        public async Task<int> PassiveCategoryCount()
        {
            var query = "Select Count(*) from Categories where Status=0 ";
            return await _connection.QueryFirstOrDefaultAsync<int>(query);
        }

        public async Task<int> ProductCount()
        {
            var query = "Select Count(*) From Products";
            return await _connection.QueryFirstOrDefaultAsync<int>(query);
        }
    }
}
