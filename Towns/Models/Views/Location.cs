using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Towns.Models.Data;

namespace Towns.Models.Views
{
    public class SimpleLocation
    {
        public string Name { get; set; }
        public int Population { get; set; }

        public string DDLatitude { get; set; }
        public string DDLongitude { get; set; }

        public void update(TownsContext context)
        {
            //Ta ut alla svenska städer i en lista
            List<World> worldCities = context.World
            .Where(t => t.Country == "Sweden")
                .ToList();

            //Hjälptal
            double latitude = Double.Parse(DDLatitude.Replace('.', ','));
            double longitude = Double.Parse(DDLongitude.Replace('.', ','));
            double min = 12345678;
            //Hitta närmsta staden
            foreach (var t in worldCities)
            {
                double katetA = (double)Math.Pow(latitude - t.DDLatitude, 2);
                double katetB = (double)Math.Pow(longitude - t.DDLongitude, 2);

                double hypotenusan = (double)Math.Sqrt(katetA + katetB);
                //Närmaste hittils
                if (hypotenusan < min)
                {
                    Name = t.Name;
                    Population = t.Population;
                    min = hypotenusan;
                }
            }
            
         
        }
    }
}
