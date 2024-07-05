using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;

namespace RealEstate.Dapper.WebUI.ViewComponents.UILayoutAboutViewComponents
{
    public class _UILayoutAboutServiceComponentPartial:ViewComponent
    {
        private readonly IAboutServiceReadApiService _aboutServiceReadApiService;

        public _UILayoutAboutServiceComponentPartial(IAboutServiceReadApiService aboutServiceReadApiService)
        {
            _aboutServiceReadApiService = aboutServiceReadApiService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _aboutServiceReadApiService.GetListAsync());
        }
    }
}
