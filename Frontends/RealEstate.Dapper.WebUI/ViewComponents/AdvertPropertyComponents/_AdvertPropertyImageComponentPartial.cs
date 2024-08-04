using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;

namespace RealEstate.Dapper.WebUI.ViewComponents.AdvertPropertyComponents
{
    public class _AdvertPropertyImageComponentPartial:ViewComponent
    {
        private readonly IProductImageReadApiService _productImageReadApiService;

        public _AdvertPropertyImageComponentPartial(IProductImageReadApiService productImageReadApiService)
        {
            _productImageReadApiService = productImageReadApiService;
        }

        public  async Task<IViewComponentResult> InvokeAsync(int productId)
        {
            var values = await _productImageReadApiService.GetProductImageListByProductIdAsync(productId);
            return View(values);
        }
    }
}
