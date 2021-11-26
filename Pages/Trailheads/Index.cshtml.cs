using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MountainBikeTrailHeads.Data;
using MountainBikeTrailHeads.Models;

namespace MountainBikeTrailHeads.Pages.Trailheads
{
    public class IndexModel : PageModel
    {
        private readonly MountainBikeTrailHeads.Data.MountainBikeTrailHeadsContext _context;

        public IndexModel(MountainBikeTrailHeads.Data.MountainBikeTrailHeadsContext context)
        {
            _context = context;
        }

        public IList<Trailhead> Trailhead { get;set; }

        public async Task OnGetAsync()
        {
            Trailhead = await _context.Trailhead.ToListAsync();
        }
    }
}
