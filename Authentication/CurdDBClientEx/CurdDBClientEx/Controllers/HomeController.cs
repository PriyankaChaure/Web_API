﻿using Microsoft.AspNetCore.Mvc;

namespace CurdDBClientEx.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult SignIn()
        {
            return View();
        }
    }
}
