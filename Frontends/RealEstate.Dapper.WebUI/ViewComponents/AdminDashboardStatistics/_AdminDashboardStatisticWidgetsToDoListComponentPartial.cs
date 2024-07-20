using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;

namespace RealEstate.Dapper.WebUI.ViewComponents.AdminDashboardStatistics
{
    public class _AdminDashboardStatisticWidgetsToDoListComponentPartial : ViewComponent
    {
        private readonly IToDoListReadApiService _toDoListReadApiService;

        public _AdminDashboardStatisticWidgetsToDoListComponentPartial(IToDoListReadApiService toDoListReadApiService)
        {
            _toDoListReadApiService = toDoListReadApiService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _toDoListReadApiService.GetListAsync());
        }
    }
}
