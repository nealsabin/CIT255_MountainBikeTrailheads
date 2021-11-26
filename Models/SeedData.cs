using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MountainBikeTrailHeads.Data;
using System;
using System.Linq;

namespace MountainBikeTrailHeads.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MountainBikeTrailHeadsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MountainBikeTrailHeadsContext>>()))
            {
                if (context.Trailhead.Any())
                {
                    return;
                }

                context.Trailhead.AddRange(
                    new Trailhead
                    {
                        Name = "South Trails",
                        Rating = 4,
                        Description = "The NTN SingleTrack trail system is a network of paths in Marquette, MI designed for non-motorized recreational use. Parts of the trail system have been around for 20 or more years, but new trails are constantly being built and now IMBA (International Mountain Biking Association) standards for design and construction are being followed. The singletrack system has received national acclaim as a premier mountain bike destination in several publications including Bike Magazine, Silent Sports Magazine and others.The current goal of the singletrack committee is to get recognition as an Epic Trail from IMBA.",
                        TrailCount = 10,
                        TotalDistance = 80,
                        TotalDescent = 3200,
                        CityNear = "Marquette, MI",
                        Latitude = 46.51433632960725,
                        Longitude = -87.41238244430868
                    },
                    new Trailhead
                    {
                        Name = "Palmer Woods",
                        Rating = 3,
                        Description = "This majestic forest reserve offers miles of hiking, cross-country skiing or snowshoeing and cycling through rolling hills and traditional northern hardwood forest. The Forest Reserve’s contiguous hardwood forest stretches over 2 miles north to south. It is located just over a mile from Big Glen Lake and just beyond the bluff that marks the western edge of Miller Hill. The trail system here is a work in progress; more trails will be created over time. In 2018, we built the first public flow-style mountain bike trail in Leelanau County at Palmer Woods Forest Reserve.",
                        TrailCount = 5,
                        TotalDistance = 8,
                        TotalDescent = 660,
                        CityNear = "Glen Arbor, MI",
                        Latitude = 44.89281605174706,
                        Longitude = -85.91537976079013
                    },
                    new Trailhead
                    {
                        Name = "VASA Pathway",
                        Rating = 4,
                        Description = "The VASA Singletrack is an excellent example of the smooth, well-maintained trails that have been built by the Michigan Mountain Biking Association in cooperation with the Department of Natural Resources. Thirteen miles of twisting singletrack wind along a groomed trail with banked corners, allowing you to turn almost without braking. There are plenty of gentle whoop-de-dos on the straight portions of the trail for an added thrill.",
                        TrailCount = 35,
                        TotalDistance = 68,
                        TotalDescent = 5439,
                        CityNear = "Traverse City, MI",
                        Latitude = 44.70191058269106,
                        Longitude = -85.48318961203985
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
