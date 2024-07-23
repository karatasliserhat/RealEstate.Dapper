using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Dapper.WebUI.Areas.EstateAgent.Controllers
{
    [Area("EstateAgent")]
    [Route("EstateAgent/[Controller]/[Action]")]
    [Authorize]
    public class EstateAgentDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
