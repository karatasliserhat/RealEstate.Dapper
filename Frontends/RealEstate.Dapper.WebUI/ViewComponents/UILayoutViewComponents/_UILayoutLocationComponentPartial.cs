using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService.IProductReadService;

namespace RealEstate.Dapper.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _UILayoutLocationComponentPartial : ViewComponent
    {
        private readonly IProductReadApiService _productReadApiService;

        public _UILayoutLocationComponentPartial(IProductReadApiService productReadApiService)
        {
            _productReadApiService = productReadApiService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _productReadApiService.GetListProductWithCategoryAndEmployeeAsync();
            return View(values);
        }
    }
}
