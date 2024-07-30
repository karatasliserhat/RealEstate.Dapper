using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService.IProductReadService;
using RealEstate.Dapper.Shared.Abstract.IUserServices;

namespace RealEstate.Dapper.WebUI.ViewComponents.EstateAgentViewComponents
{
    public class _EstateAgentDashboardStatisticsRecentSalesComponentPartial : ViewComponent
    {
        private readonly IProductReadApiService _productReadApiService;
        private readonly IUserService _userService;
        private readonly IDataProtector _dataProtector;
        public _EstateAgentDashboardStatisticsRecentSalesComponentPartial(IProductReadApiService productReadApiService, IUserService userService, IDataProtectionProvider dataProvider)
        {
            _dataProtector = dataProvider.CreateProtector("EstateAgentDashboardStatisticsRecentSalesComponentPartial");
            _productReadApiService = productReadApiService;
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            int howProduct = 5;
            var values = await _productReadApiService.GetListLastProductAsync(howProduct, int.Parse(_userService.GetUser));
            values.ForEach(x => x.DataProtect = _dataProtector.Protect(x.Id.ToString()));
            return View(values);
        }
    }
}
