﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Dapper.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    public class AdminLayaoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
