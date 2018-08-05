using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Towns.Models.Data
{
    public class World
    {
        public int Id { get; set; }
        public int? Kod { get; set; }
        public string Town { get; set; }
        public string Region { get; set; }
        public int Population { get; set; }
        public double? Area { get; set; }
        public double? LandArea { get; set; }
        public double? LakeArea1 { get; set; }
        public double? LakeArea2 { get; set; }
        public double? SeaAra { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string Abstract { get; set; }

        public string Name { get; set; }
        public string Country { get; set; }
        public double DDLatitude { get; set; }
        public double DDLongitude { get; set; }
     
    }
}
