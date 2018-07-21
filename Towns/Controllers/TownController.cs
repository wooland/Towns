using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Towns.Models.Views;

namespace Towns.Controllers
{
    public class TownController : Controller
    {
        public IActionResult Index(TownViewModel town)
        {
            return View(town);
        }
    }
}