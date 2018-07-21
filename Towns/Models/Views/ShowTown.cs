using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Towns.Models.Data;

namespace Towns.Models.Views
{
    public class ShowTown
    {
        public List<TownViewModel> allTowns { get; set; }
        public ShowTown(TownsContext context)
        {
            foreach (var town in context.Sweden)
            {
                allTowns.Add(new TownViewModel { ID = town.Id, Name = town.Town, Population = town.Population });
            }
        }

        
    }
    
}
