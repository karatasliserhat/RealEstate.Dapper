using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;

namespace RealEstate.Dapper.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _UILayoutStepsComponentPartial : ViewComponent
    {
        private readonly IStepGridReadApiService _stepGridReadApiService;

        public _UILayoutStepsComponentPartial(IStepGridReadApiService stepGridReadApiService)
        {
            _stepGridReadApiService = stepGridReadApiService;
        }

        public async Task< IViewComponentResult> InvokeAsync()
        {
            return View(await _stepGridReadApiService.GetListAsync());
        }
    }
}
