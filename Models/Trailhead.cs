using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MountainBikeTrailHeads.Models
{
    public class Trailhead
    {
        public int ID { get; set; }

        [Display(Name = "Trail System Name")]
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        
        [Display(Name = "Trail Count")]
        public int TrailCount { get; set; }

        [Display(Name = "Total Distance")]
        public int TotalDistance { get; set; }

        [Display(Name = "Total Descent")]
        public int TotalDescent { get; set; }
        [Display(Name = "City Near")]
        public string CityNear { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
