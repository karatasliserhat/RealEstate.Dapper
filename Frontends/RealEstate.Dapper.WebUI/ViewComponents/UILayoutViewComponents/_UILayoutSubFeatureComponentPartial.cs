using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;

namespace RealEstate.Dapper.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _UILayoutSubFeatureComponentPartial : ViewComponent
    {
        private readonly ISubFeatureReadApiService _subFeatureReadApiService;

        public _UILayoutSubFeatureComponentPartial(ISubFeatureReadApiService subFeatureReadApiService)
        {
            _subFeatureReadApiService = subFeatureReadApiService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View(await _subFeatureReadApiService.GetListAsync("GetSubFeature"));
        }
    }
}
