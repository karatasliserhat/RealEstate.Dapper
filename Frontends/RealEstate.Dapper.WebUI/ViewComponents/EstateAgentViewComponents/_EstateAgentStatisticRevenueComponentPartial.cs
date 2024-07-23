using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.Shared.Abstract.IUserServices;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.WebUI.ViewComponents.EstateAgentViewComponents
{
    public class _EstateAgentStatisticRevenueComponentPartial : ViewComponent
    {
        private readonly IEstateAgentDashboardReadApiService<ResultProductCountViewModel> _resultProductCount;
        private readonly IEstateAgentDashboardReadApiService<GetProductCountByEmployeeIdViewModel> _getProductCountEmloyeeId;
        private readonly IEstateAgentDashboardReadApiService<GetProductCountByStatusFalseViewModel> _getProductCountStatusFalse;
        private readonly IEstateAgentDashboardReadApiService<GetProductCountByStatusTrueViewModel> _getProductCountStatusTrue;
        private readonly IUserService _userService;
        public _EstateAgentStatisticRevenueComponentPartial(IEstateAgentDashboardReadApiService<ResultProductCountViewModel> resultProductCount, IEstateAgentDashboardReadApiService<GetProductCountByEmployeeIdViewModel> getProductCountEmloyeeId, IEstateAgentDashboardReadApiService<GetProductCountByStatusFalseViewModel> getProductCountStatusFalse, IEstateAgentDashboardReadApiService<GetProductCountByStatusTrueViewModel> getProductCountStatusTrue, IUserService userService)
        {
            _resultProductCount = resultProductCount;
            _getProductCountEmloyeeId = getProductCountEmloyeeId;
            _getProductCountStatusFalse = getProductCountStatusFalse;
            _getProductCountStatusTrue = getProductCountStatusTrue;
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _resultProductCount.GetResultViewCount("GetProductCount");
            ViewBag.ProductCount = values.Count;

            var valueProductCountEmployee = await _getProductCountEmloyeeId.GetResultViewCount("ProductCountByEmployeeId", int.Parse(_userService.GetUser));
            ViewBag.EmployeeProductCount = valueProductCountEmployee.Count;


            var productCountTrue = await _getProductCountStatusTrue.GetResultViewCount("ProductCountByStatusTrue", int.Parse(_userService.GetUser));
            ViewBag.ProductCountTrue = productCountTrue.Count;

            var productCountFalse = await _getProductCountStatusFalse.GetResultViewCount("ProductCountByStatusFalse", int.Parse(_userService.GetUser));
            ViewBag.ProductCountFalse = productCountFalse.Count;

            return View();
        }
    }
}
