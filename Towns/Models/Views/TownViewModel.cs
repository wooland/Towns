using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Towns.Models.Data;

namespace Towns.Models.Views
{
    public class TownViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }

        public Sweden ValidateTown(TownViewModel town, TownsContext context) {
            Sweden sweTown = context.Sweden
                /*  Use for Eager Loading commented because we r Lazy!
                 *  .Include(i => i.EmployeeTerritories)
                  .ThenInclude(i => i.Territory) **/
                .Where(s => s.Town.StartsWith(town.Name))
                .FirstOrDefault();

            return sweTown;

}
    }
}
