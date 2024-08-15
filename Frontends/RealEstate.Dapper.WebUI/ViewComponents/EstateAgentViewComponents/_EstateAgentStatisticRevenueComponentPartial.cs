using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.Shared.Abstract.IUserServices;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.WebUI.ViewComponents.EstateAgentViewComponents
{
    public class _EstateAgentStatisticRevenueComponentPartial : ViewComponent
    {
        private readonly IEstateAgentDashboardReadApiService _apiService;
        private readonly IUserService _userService;
        private readonly IStatisticsReadApiService<ResultProductCountViewModel> _statisticsReadApiService;
        public _EstateAgentStatisticRevenueComponentPartial(IEstateAgentDashboardReadApiService apiService, IUserService userService, IStatisticsReadApiService<ResultProductCountViewModel> statisticsReadApiService)
        {
            _apiService = apiService;
            _userService = userService;
            _statisticsReadApiService = statisticsReadApiService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _statisticsReadApiService.GetStatisticResult("GetProductCount");
            ViewBag.ProductCount = values.Count;

            var valueProductCountEmployee = await _apiService.GetProductCountByEmployeeId(int.Parse(_userService.GetUser));
            ViewBag.EmployeeProductCount = valueProductCountEmployee.Count;


            var productCountTrue = await _apiService.GetProductCountByStatusTrue(int.Parse(_userService.GetUser));
            ViewBag.ProductCountTrue = productCountTrue.Count;

            var productCountFalse = await _apiService.GetProductCountByStatusFalse(int.Parse(_userService.GetUser));
            ViewBag.ProductCountFalse = productCountFalse.Count;

            return View();
        }
    }
}
