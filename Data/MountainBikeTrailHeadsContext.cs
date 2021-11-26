using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MountainBikeTrailHeads.Models;

namespace MountainBikeTrailHeads.Data
{
    public class MountainBikeTrailHeadsContext : DbContext
    {
        public MountainBikeTrailHeadsContext (DbContextOptions<MountainBikeTrailHeadsContext> options)
            : base(options)
        {
        }

        public DbSet<MountainBikeTrailHeads.Models.Trailhead> Trailhead { get; set; }
    }
}
