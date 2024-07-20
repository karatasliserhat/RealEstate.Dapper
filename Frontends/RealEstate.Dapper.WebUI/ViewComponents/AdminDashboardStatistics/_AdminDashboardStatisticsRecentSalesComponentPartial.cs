using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService.IProductReadService;

namespace RealEstate.Dapper.WebUI.ViewComponents.AdminDashboardStatistics
{
    public class _AdminDashboardStatisticsRecentSalesComponentPartial : ViewComponent
    {
        private readonly IProductReadApiService _productReadApiService;
        private readonly IDataProtector _dataProtector;
        public _AdminDashboardStatisticsRecentSalesComponentPartial(IProductReadApiService productReadApiService, IDataProtectionProvider dataProtectionProvider)
        {
            _dataProtector = dataProtectionProvider.CreateProtector("AdminDashboardStatisticsRecentSales");
            _productReadApiService = productReadApiService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var hawProductCount = 5;
            ViewBag.LastProductCount = hawProductCount;
            var values = await _productReadApiService.GetListLastProductAsync(hawProductCount);
            values.ForEach(x => x.DataProtect = _dataProtector.Protect(x.Id.ToString()));
            return View(values);
        }
    }
}
