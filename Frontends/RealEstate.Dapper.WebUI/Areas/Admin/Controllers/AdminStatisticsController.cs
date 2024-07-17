using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    public class AdminStatisticsController : Controller
    {
        private readonly IStatisticsReadApiService<ResultActiveCategoryCountViewModel> _activeCategoryCount;
        private readonly IStatisticsReadApiService<ResultActiveEmployeeCountViewModel> _activeEmployeeCount;
        private readonly IStatisticsReadApiService<ResultAparmentCountViewModel> _apartmentCount;
        private readonly IStatisticsReadApiService<ResultAvarageProductByRentViewModel> _rentProduct;
        private readonly IStatisticsReadApiService<ResultAvarageProductBySentViewModel> _sentProduct;
        private readonly IStatisticsReadApiService<ResultCategoryCountViewModel> _categoryCount;
        private readonly IStatisticsReadApiService<ResultAvarageRoomCountViewModel> _roomCount;
        private readonly IStatisticsReadApiService<ResultCategoryNameByMaxProductCountViewModel> _categoryName;
        private readonly IStatisticsReadApiService<ResultCityNameByMaxProductCountViewModel> _cityNameMaxProduct;
        private readonly IStatisticsReadApiService<ResultDifferentCityCountViewModel> _differentCityCount;
        private readonly IStatisticsReadApiService<ResultEmployeeNameByMaxProductCountViewModel> _employeeNameMaxProduct;
        private readonly IStatisticsReadApiService<ResultLastProductPriceViewModel> _lastProductPrice;
        private readonly IStatisticsReadApiService<ResultNewestBuildingYearViewModel> _newestBuildingYear;
        private readonly IStatisticsReadApiService<ResultOldestBuildingYearQueryViewModel> _oldestBuildingYear;
        private readonly IStatisticsReadApiService<ResultPassiveCategoryCountViewModel> _passiveCategoryCount;
        private readonly IStatisticsReadApiService<ResultProductCountViewModel> _productCount;
        public AdminStatisticsController(
            IStatisticsReadApiService<ResultActiveCategoryCountViewModel> activecategoryCount,
            IStatisticsReadApiService<ResultActiveEmployeeCountViewModel> activeEmployeeCount,
            IStatisticsReadApiService<ResultAparmentCountViewModel> apartmentCount,
            IStatisticsReadApiService<ResultAvarageProductByRentViewModel> rentProduct,
            IStatisticsReadApiService<ResultAvarageProductBySentViewModel> sentProduct,
            IStatisticsReadApiService<ResultAvarageRoomCountViewModel> roomCount,
            IStatisticsReadApiService<ResultCategoryNameByMaxProductCountViewModel> categoryName,
            IStatisticsReadApiService<ResultCategoryCountViewModel> categoryCount,
            IStatisticsReadApiService<ResultCityNameByMaxProductCountViewModel> cityNameMaxProduct,
            IStatisticsReadApiService<ResultDifferentCityCountViewModel> differentCityCount,
            IStatisticsReadApiService<ResultEmployeeNameByMaxProductCountViewModel> employeeNameMaxProduct,
            IStatisticsReadApiService<ResultLastProductPriceViewModel> lastProductPrice,
            IStatisticsReadApiService<ResultNewestBuildingYearViewModel> newestBuildingYear,
            IStatisticsReadApiService<ResultOldestBuildingYearQueryViewModel> oldestBuildingYear,
            IStatisticsReadApiService<ResultPassiveCategoryCountViewModel> passiveCategoryCount,
            IStatisticsReadApiService<ResultProductCountViewModel> productCount)
        {
            _activeCategoryCount = activecategoryCount;
            _activeEmployeeCount = activeEmployeeCount;
            _apartmentCount = apartmentCount;
            _rentProduct = rentProduct;
            _sentProduct = sentProduct;
            _roomCount = roomCount;
            _categoryName = categoryName;
            _categoryCount = categoryCount;
            _cityNameMaxProduct = cityNameMaxProduct;
            _differentCityCount = differentCityCount;
            _employeeNameMaxProduct = employeeNameMaxProduct;
            _lastProductPrice = lastProductPrice;
            _newestBuildingYear = newestBuildingYear;
            _oldestBuildingYear = oldestBuildingYear;
            _passiveCategoryCount = passiveCategoryCount;
            _productCount = productCount;
        }

        public async Task<IActionResult> Index()
        {

            var activeCategory = await _activeCategoryCount.GetStatisticResult("GetActiveCategoryCount");
            ViewBag.ActiveCategoryCount = activeCategory.Count;

            var activeEmployee = await _activeEmployeeCount.GetStatisticResult("GetActiveEmployeeCount");
            ViewBag.ActiveEmployeeCount = activeEmployee.Count;

            var apartmentCount = await _apartmentCount.GetStatisticResult("GetApartmentCount");
            ViewBag.ApartmentCount = apartmentCount.Count;

            var rentProduct = await _rentProduct.GetStatisticResult("GetAvarageProductByRent");
            ViewBag.AvarageProductRent = String.Format("₺ {0:N}", rentProduct.AvarageProductRent);


            var sentProduct = await _sentProduct.GetStatisticResult("GetAvarageProductBySent");
            ViewBag.AvarageProductSent = String.Format("₺ {0:N}", sentProduct.AvarageProductSent);

            var avarageRoom = await _roomCount.GetStatisticResult("GetAvarageRoomCount");
            ViewBag.AvarageRoom = avarageRoom.Count;

            var categoryName = await _categoryName.GetStatisticResult("GetCategoryNameByMaxProductCount");
            ViewBag.CategoryName = categoryName.CategoryName;

            var categoryCount = await _categoryCount.GetStatisticResult("GetCategoryCount");
            ViewBag.CategoryCount = categoryCount.Count;

            var cityName = await _cityNameMaxProduct.GetStatisticResult("GetCityNameByMaxProductCount");
            ViewBag.CityNameMaxProduct = cityName.CityName;

            var differentCityCount = await _differentCityCount.GetStatisticResult("GetDifferentCityCount");
            ViewBag.DifferentCityCount = differentCityCount.Count;

            var employeeName = await _employeeNameMaxProduct.GetStatisticResult("GetEmployeeNameByMaxProductCount");
            ViewBag.EmployeeName = employeeName.EmployeeName;

            var lastProductPrice = await _lastProductPrice.GetStatisticResult("GetLastProductPrice");
            ViewBag.LastProductPrice = String.Format("₺ {0:N}", lastProductPrice.LastPrice);

            var newestBUildingYear = await _newestBuildingYear.GetStatisticResult("GetNewestBuildingYear");
            ViewBag.NewestBuildingYear = newestBUildingYear.BuildingYear;

            var oldestBUildingYear = await _oldestBuildingYear.GetStatisticResult("GetOldestBuildingYear");
            ViewBag.OldestBuildingYear = oldestBUildingYear.BuildingYear;

            var passiveCategoryCount = await _passiveCategoryCount.GetStatisticResult("GetPassiveCategoryCount");
            ViewBag.PassiveCategoryCount = passiveCategoryCount.PassiveCategoryCount;

            var productCount = await _productCount.GetStatisticResult("GetProductCount");
            ViewBag.ProductCount = productCount.Count;

            return View();

        }
    }
}
