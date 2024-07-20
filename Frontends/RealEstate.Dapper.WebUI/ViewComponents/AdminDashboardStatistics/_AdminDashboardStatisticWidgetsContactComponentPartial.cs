using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;

namespace RealEstate.Dapper.WebUI.ViewComponents.AdminDashboardStatistics
{
    public class _AdminDashboardStatisticWidgetsContactComponentPartial : ViewComponent
    {
        private readonly IContactReadApiService _contactReadApiService;

        public _AdminDashboardStatisticWidgetsContactComponentPartial(IContactReadApiService contactReadApiService)
        {
            _contactReadApiService = contactReadApiService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _contactReadApiService.GetLastContactsAsync(4);
            return View(values);
        }
    }
}
