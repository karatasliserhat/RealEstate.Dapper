using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;

namespace RealEstate.Dapper.WebUI.ViewComponents.AdvertPropertyComponents
{
    public class _AdvertPropertyAmenityComponentPartial : ViewComponent
    {
        private readonly IPropertyAmenityReadApiService _propertyAmenityReadApiService;

        public _AdvertPropertyAmenityComponentPartial(IPropertyAmenityReadApiService propertyAmenityReadApiService)
        {
            _propertyAmenityReadApiService = propertyAmenityReadApiService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int ProductId)
        {
            return View(await _propertyAmenityReadApiService.GetPropertyAmenityByProductIdStatusTrue(ProductId));
        }
    }
}
