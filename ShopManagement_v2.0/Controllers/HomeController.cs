using System;
using Microsoft.AspNetCore.Mvc;
using ShopManagement_v2.Models;

namespace ShopManagement_v2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
