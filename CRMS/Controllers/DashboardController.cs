﻿using Microsoft.AspNetCore.Mvc;

namespace CRMS.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
