using System;
using System.Collections.Generic;

namespace Towns.Models.Data
{
    public partial class Sweden
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
    }
}
