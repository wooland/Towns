using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Towns.Models.Data;
using Towns.Models.Views;

namespace Towns.Controllers
{
    public class TownController : Controller
    {
        private TownsContext context;
        public TownController(TownsContext context)
        {
            this.context = context;
        }
        public IActionResult Index(TownViewModel town)
        {
            ShowTown towns = new ShowTown(context);
            return View(towns);
        }
    }
}