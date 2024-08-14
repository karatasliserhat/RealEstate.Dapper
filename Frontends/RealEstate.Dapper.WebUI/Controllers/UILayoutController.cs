using Microsoft.AspNetCore.Mvc;
using RealEstate.Dapper.Shared.Abstract.IApiReadService;
using RealEstate.Dapper.ViewModel.ViewModels;
using RealEstate.Dapper.WebUI.Models;
using RealEstate.Dapper.WebUI.Tools;

namespace RealEstate.Dapper.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        private readonly ICategoryReadApiService _categoryReadApiService;
        public UILayoutController(ICategoryReadApiService categoryReadApiService)
        {
            _categoryReadApiService = categoryReadApiService;
        }

        public IActionResult UILayout()
        {
            
            return View();

        }
        
    }
}
