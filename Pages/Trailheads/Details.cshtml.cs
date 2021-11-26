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
    public class DetailsModel : PageModel
    {
        private readonly MountainBikeTrailHeads.Data.MountainBikeTrailHeadsContext _context;

        public DetailsModel(MountainBikeTrailHeads.Data.MountainBikeTrailHeadsContext context)
        {
            _context = context;
        }

        public Trailhead Trailhead { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Trailhead = await _context.Trailhead.FirstOrDefaultAsync(m => m.ID == id);

            if (Trailhead == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
