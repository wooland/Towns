using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Towns.Models.Views;

namespace Towns.Controllers
{
    public class SimpleLocController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public RedirectToActionResult Index(SimpleLocation loc)
        {
            return RedirectToAction("Index", "WorldTown", loc);
            
        }
    }
}