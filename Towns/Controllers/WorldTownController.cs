using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Towns.Models.Data;
using Towns.Models.Views;

namespace Towns.Controllers
{
    public class WorldTownController : Controller
    {
        private TownsContext context;
        public WorldTownController(TownsContext context)
        {
            this.context = context;
        }
        public IActionResult Index(SimpleLocation loc)
        {
            loc.update(context);
            return View(loc);
        }
    }
}