using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;

namespace RealEstate.Dapper.WebUI.Controllers
{
    public class AdvertController : Controller
    {
        private readonly IProductDetailReadApiService _productDetailReadApiService;
        private readonly IDataProtector _dataProtector;
        public AdvertController(IProductDetailReadApiService productDetailReadApiService, IDataProtectionProvider dataProvider)
        {
            _dataProtector = dataProvider.CreateProtector("AdvertController");
            _productDetailReadApiService = productDetailReadApiService;
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

            var value=await _productDetailReadApiService.GetByIdAsync("GetProductDetailAndByProductId", Id);
            return View(value);
        }
    }
}
