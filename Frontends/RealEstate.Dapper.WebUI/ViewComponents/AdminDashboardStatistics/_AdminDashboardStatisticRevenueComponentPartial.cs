using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.WebUI.ViewComponents.AdminDashboardStatistics
{
    public class _AdminDashboardStatisticRevenueComponentPartial : ViewComponent
    {
        private readonly IStatisticsReadApiService<ResultProductCountViewModel> _resultProductCount;
        private readonly IStatisticsReadApiService<ResultEmployeeNameByMaxProductCountViewModel> _resultEmployeeNameByMaxProductCount;
        private readonly IStatisticsReadApiService<ResultDifferentCityCountViewModel> _resultDifferentCityCount;
        private readonly IStatisticsReadApiService<ResultAvarageProductByRentViewModel> _resultAvarageProductByRent;
        public _AdminDashboardStatisticRevenueComponentPartial(IStatisticsReadApiService<ResultProductCountViewModel> resultProductCount, IStatisticsReadApiService<ResultEmployeeNameByMaxProductCountViewModel> resultEmployeeNameByMaxProductCount, IStatisticsReadApiService<ResultDifferentCityCountViewModel> resultDifferentCityCount, IStatisticsReadApiService<ResultAvarageProductByRentViewModel> resultAvarageProductByRent)
        {
            _resultProductCount = resultProductCount;
            _resultEmployeeNameByMaxProductCount = resultEmployeeNameByMaxProductCount;
            _resultDifferentCityCount = resultDifferentCityCount;
            _resultAvarageProductByRent = resultAvarageProductByRent;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var resultProduct = await _resultProductCount.GetStatisticResult("GetProductCount");
            ViewBag.ProductCount = resultProduct.Count;

            var resultEmployee = await _resultEmployeeNameByMaxProductCount.GetStatisticResult("GetEmployeeNameByMaxProductCount");
            ViewBag.EmployeeMaxProductCount = resultEmployee.EmployeeName;

            var resultCity = await _resultDifferentCityCount.GetStatisticResult("GetDifferentCityCount");
            ViewBag.CityCount = resultCity.Count;

            var result = await _resultAvarageProductByRent.GetStatisticResult("GetAvarageProductByRent");
            ViewBag.AvarageRentProduct = String.Format("₺ {0:N}", result.AvarageProductRent);
            
            return View();
        }
    }
}
