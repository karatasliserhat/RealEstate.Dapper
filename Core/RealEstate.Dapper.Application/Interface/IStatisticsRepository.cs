namespace RealEstate.Dapper.Application.Interface
{
    public interface IStatisticsRepository
    {
        Task<int> CategoryCount();
        Task<int> ActiveCategoryCount();
        Task<int> PassiveCategoryCount();
        Task<int> ProductCount();
        Task<int> ApartmentCount();
        Task<string> EmployeeNameByMaxProductCount();
        Task<string> CategoryNameByMaxProductCount();
        Task<decimal> AvarageProductByRent();
        Task<decimal> AvarageProductBySent();
        Task<string> CityNameByMaxProductCount();
        Task<int> DifferentCityCount();
        Task<decimal> LastProductPrice();
        Task<int> NewestBuildingYear();
        Task<int> OldestBuildingYear();
        Task<int> ActiveEmployeeCount();
        Task<int> AvarageRoomCount();
    }
}
