using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;

namespace RealEstate.Dapper.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _UILayoutAboutComponentPartial : ViewComponent
    {
        private readonly IAboutDetailReadApiService _readApiService;

        public _UILayoutAboutComponentPartial(IAboutDetailReadApiService readApiService)
        {
            _readApiService = readApiService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await _readApiService.GetListAsync();
            return View(result.FirstOrDefault());
        }
    }
}
