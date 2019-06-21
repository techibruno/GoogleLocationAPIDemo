using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DistanceCalculator.Models.Entity
{
    public class Geometry
    {
        public Location location { get; set; }
        public string location_type { get; set; }
        public dynamic viewport { get; set; }
        public Bounds bounds { get; set; }
    }
}
