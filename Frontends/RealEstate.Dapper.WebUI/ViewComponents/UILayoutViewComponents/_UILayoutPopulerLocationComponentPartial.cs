using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;

namespace RealEstate.Dapper.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _UILayoutPopulerLocationComponentPartial : ViewComponent
    {
        private readonly IPopulerLocationReadApiService _poopulerLocationReadApiService;

        public _UILayoutPopulerLocationComponentPartial(IPopulerLocationReadApiService poopulerLocationReadApiService)
        {
            _poopulerLocationReadApiService = poopulerLocationReadApiService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _poopulerLocationReadApiService.GetListAsync());
        }
    }
}
