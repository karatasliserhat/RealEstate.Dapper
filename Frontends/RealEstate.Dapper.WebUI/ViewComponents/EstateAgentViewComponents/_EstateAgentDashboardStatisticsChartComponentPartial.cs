using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;

namespace RealEstate.Dapper.WebUI.ViewComponents.EstateAgentViewComponents
{
    public class _EstateAgentDashboardStatisticsChartComponentPartial : ViewComponent
    {
        private readonly IEstateAgentDashboardReadApiService _apiService;

        public _EstateAgentDashboardStatisticsChartComponentPartial(IEstateAgentDashboardReadApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _apiService.ResultCityCount();
            return View(values);
        }
    }
}
