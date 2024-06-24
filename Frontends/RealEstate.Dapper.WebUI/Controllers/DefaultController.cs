using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Dapper.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private void GetViewBag(string home,string pages,string page)
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
    }
}
