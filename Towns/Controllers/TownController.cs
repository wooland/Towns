using Microsoft.AspNetCore.Mvc;
using Towns.Models.Data;
using Towns.Models.Views;

namespace Towns.Controllers
{
    public class TownController : Controller
    {
        public static string filepath = "C:\\Projects\\Towns\\DataSwe.csv";

        private TownsContext context;
        public TownController(TownsContext context)
        {
            this.context = context;
        }
        public IActionResult Index(TownViewModel town)
        {
            //ReadListFromFile();
            Sweden ValTown = town.ValidateTown(town, context);
            ShowTown towns = new ShowTown(context);

            return View(new TownViewModel {Name = ValTown.Town, Population = ValTown.Population, ID = ValTown.Id });
        }

        //This method was used once to read a csv file into the database.
        //private void ReadListFromFile()
        //{
        //    using (StreamReader reader = new StreamReader(filepath, Encoding.GetEncoding("iso-8859-1")))
        //    {
        //        string line = "";
        //        line = reader.ReadLine();
        //        while (line != null)
        //        {
        //            string[] lineData = line.Split(';');
        //            Sweden sweTown = new Sweden
        //            {
        //                Kod = Convert.ToInt32(lineData[0]),
        //                Town = lineData[1],
        //                Region = lineData[2],
        //                Population = Convert.ToInt32(lineData[3]),
        //                Area = Double.Parse(lineData[4].Replace('.', ',')),
        //                LandArea = Double.Parse(lineData[5].Replace('.', ',')),
        //                LakeArea1 = Double.Parse(lineData[6].Replace('.', ',')),
        //                LakeArea2 = Double.Parse(lineData[7].Replace('.', ',')),
        //                SeaAra = Double.Parse(lineData[8].Replace('.', ',')),
        //                LastUpdated = DateTime.Now
        //            };

        //            context.Add(sweTown);

        //            line = reader.ReadLine();
        //        }
        //        context.SaveChanges();
        //    }
        //}
    }
}