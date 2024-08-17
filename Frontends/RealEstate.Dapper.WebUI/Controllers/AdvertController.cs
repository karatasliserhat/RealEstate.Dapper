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


        private string CreateSlug(string title)
        {
            title = title.ToLowerInvariant(); // Küçük harfe çevir
            title = title.Replace(" ", "-"); // Boşlukları tire ile değiştir
            title = System.Text.RegularExpressions.Regex.Replace(title, @"[^a-z0-9\s-]", ""); // Geçersiz karakterleri kaldır
            title = System.Text.RegularExpressions.Regex.Replace(title, @"\s+", " ").Trim(); // Birden fazla boşluğu tek boşluğa indir ve kenar boşluklarını kaldır
            title = System.Text.RegularExpressions.Regex.Replace(title, @"\s", "-"); // Boşlukları tire ile değiştir

            return title;
        }
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
            values.ForEach(x => x.SlugUrlRegister = CreateSlug(x.SlugUrl));
            return View(values);
        }

        [HttpGet("property/{slugUrl}/{dataid}")]
        public async Task<IActionResult> PropertyAdvert(string slugUrl, string dataid)
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
