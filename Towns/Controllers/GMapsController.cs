using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Towns.Models.Data;
using Towns.Models.Views;

namespace Towns.Controllers
{
    public class GMapsController : Controller
    {

        private TownsContext context;
        public GMapsController(TownsContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public RedirectToActionResult Index(SimpleLocation loc)
        {
            return RedirectToAction("Index", "WorldTown");
        }
        [HttpGet]
        public IActionResult WorldTown(SimpleLocation loc)
        {
            return View(loc);
        }
    }
}