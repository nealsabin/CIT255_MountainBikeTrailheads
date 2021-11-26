using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MountainBikeTrailHeads.Data;
using MountainBikeTrailHeads.Models;

namespace MountainBikeTrailHeads.Pages.Trailheads
{
    public class EditModel : PageModel
    {
        private readonly MountainBikeTrailHeads.Data.MountainBikeTrailHeadsContext _context;

        public EditModel(MountainBikeTrailHeads.Data.MountainBikeTrailHeadsContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Trailhead).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrailheadExists(Trailhead.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TrailheadExists(int id)
        {
            return _context.Trailhead.Any(e => e.ID == id);
        }
    }
}
