using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MountainBikeTrailHeads.Models
{
    public class Trailhead
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public int TrailCount { get; set; }
        public int TotalDistance { get; set; }
        public int TotalDescent { get; set; }
        public string CityNear { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
