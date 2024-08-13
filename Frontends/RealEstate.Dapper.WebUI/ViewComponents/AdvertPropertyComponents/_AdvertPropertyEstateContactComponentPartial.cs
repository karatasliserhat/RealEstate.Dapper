using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;

namespace RealEstate.Dapper.WebUI.ViewComponents.AdvertPropertyComponents
{
    public class _AdvertPropertyEstateContactComponentPartial : ViewComponent
    {
        private readonly IAppUserReadApiService _appUserReadApiService;

        public _AdvertPropertyEstateContactComponentPartial(IAppUserReadApiService appUserReadApiService)
        {
            _appUserReadApiService = appUserReadApiService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int appUserId)
        {
            var values = await _appUserReadApiService.GetByIdAsync("GetAppUserById", appUserId);
            return View(values);
        }
    }
}
