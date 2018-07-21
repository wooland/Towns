using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Towns.Models.Data;
using Towns.Models.Views;

namespace Towns.Controllers
{
    public class TownInputController : Controller
    {
        private TownsContext context;
        public TownInputController(TownsContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult ShowTown()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public RedirectToActionResult Index(TownViewModel town)
        {
            return RedirectToAction("Index", "Town");
        }
    }
}