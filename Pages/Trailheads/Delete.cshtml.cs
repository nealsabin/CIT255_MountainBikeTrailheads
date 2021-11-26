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
    public class DeleteModel : PageModel
    {
        private readonly MountainBikeTrailHeads.Data.MountainBikeTrailHeadsContext _context;

        public DeleteModel(MountainBikeTrailHeads.Data.MountainBikeTrailHeadsContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Trailhead = await _context.Trailhead.FindAsync(id);

            if (Trailhead != null)
            {
                _context.Trailhead.Remove(Trailhead);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
