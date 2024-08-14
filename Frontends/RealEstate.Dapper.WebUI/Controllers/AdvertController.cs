using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.Shared.Abstract.IApiReadService.IProductReadService;

namespace RealEstate.Dapper.WebUI.Controllers
{
    public class AdvertController : Controller
    {
        private readonly IProductDetailReadApiService _productDetailReadApiService;
        private readonly IDataProtector _dataProtector;
        private readonly IProductReadApiService _productsReadApiService;



        public AdvertController(IProductDetailReadApiService productDetailReadApiService, IDataProtectionProvider dataProvider, IProductReadApiService productsReadApiService)
        {
            _dataProtector = dataProvider.CreateProtector("AdvertController");
            _productDetailReadApiService = productDetailReadApiService;
            _productsReadApiService = productsReadApiService;
        }

        private void GetViewBag(string home, string pages, string page)
        {
            ViewBag.Home = home;
            ViewBag.Pages = pages;
            ViewBag.Page = page;
        }
        public async Task<IActionResult> Index()
        {
            GetViewBag("Anasayfa", "İlanlar", "");

            var values = await _productDetailReadApiService.GetListAsync("GetProductAndDetailList");
            values.ForEach(x => x.DataProtect = _dataProtector.Protect(x.Id.ToString()));
            return View(values);
        }

        public async Task<IActionResult> PropertyAdvert(string dataid)
        {

            GetViewBag("Anasayfa", "İlanlar", "İlan Detayı");
            int Id = int.Parse(_dataProtector.Unprotect(dataid));

            var value = await _productDetailReadApiService.GetByIdAsync("GetProductDetailAndByProductId", Id);
            return View(value);
        }
        public async Task<IActionResult> PropertySearchList(string SeacrhKeyValue, int CategoryId, string City)
        {
            GetViewBag("Anasayfa", "İlanlar", "İlan Arama Sonucu");
            SeacrhKeyValue = TempData["SerchKeyValues"]?.ToString();
            CategoryId = int.Parse(TempData["CategoryId"] == null ? "0" : TempData["CategoryId"].ToString());
            City = TempData["City"]?.ToString();
            if (SeacrhKeyValue is not null && City is not null)
            {
                var values = await _productsReadApiService.GetProductListBySearchQuery(SeacrhKeyValue, CategoryId, City);
                return View(values);

            }
            return RedirectToAction(nameof(Index), "Default");
        }
    }
}
