using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.WebUI.Tools;

namespace RealEstate.Dapper.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetAppUserAndCategorySelectList _categoryReadApiService;

        public DefaultController(GetAppUserAndCategorySelectList categoryReadApiService)
        {
            _categoryReadApiService = categoryReadApiService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _categoryReadApiService.EmployeeAndCategorySelectList();
            ViewBag.CategoryList = values.CategoryList;
            return View();
        }
        private void GetViewBag(string home, string pages, string page)
        {
            ViewBag.Home = home;
            ViewBag.Pages = pages;
            ViewBag.Page = page;
        }
        public IActionResult Contact()
        {
            GetViewBag("Anasayfa", "Sayfalar", "İletişim");

            return View();
        }
        [HttpGet]
        public PartialViewResult SearchProperty()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult SearchProperty(string SearchKeyValue, int CategoryId, string City)
        {
            TempData["SerchKeyValues"] = SearchKeyValue;
            TempData["CategoryId"] = CategoryId;
            TempData["City"] = City;
            return RedirectToAction("PropertySearchList", "Advert");
        }
    }
}
