﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Dapper.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _UILayoutHeadComponentPartial : ViewComponent
    {
        public  IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
