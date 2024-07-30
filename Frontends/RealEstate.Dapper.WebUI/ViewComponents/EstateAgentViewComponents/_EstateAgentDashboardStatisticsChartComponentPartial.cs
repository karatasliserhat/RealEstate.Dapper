using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.ViewModel.ViewModels;

namespace RealEstate.Dapper.WebUI.ViewComponents.EstateAgentViewComponents
{
    public class _EstateAgentDashboardStatisticsChartComponentPartial : ViewComponent
    {
        private readonly IEstateAgentDashboardReadApiService<ResultCityCountViewModel> _apiService;

        public _EstateAgentDashboardStatisticsChartComponentPartial(IEstateAgentDashboardReadApiService<ResultCityCountViewModel> apiService)
        {
            _apiService = apiService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View(await _apiService.GetResultViewList("GetLastFiveCountCity"));
        }
    }
}
