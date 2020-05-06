using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopManagement_v2.Models;

namespace ShopManagement_v2.Controllers
{
    public class AppointmentController : Controller
    {
        private ShopContext context;
        public AppointmentController(ShopContext ctx)
        {
            context = ctx; 
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}