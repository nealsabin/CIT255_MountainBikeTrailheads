using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MountainBikeTrailHeads.Data;
using MountainBikeTrailHeads.Models;

namespace MountainBikeTrailHeads.Pages.Trailheads
{
    public class CreateModel : PageModel
    {
        private readonly MountainBikeTrailHeads.Data.MountainBikeTrailHeadsContext _context;

        public CreateModel(MountainBikeTrailHeads.Data.MountainBikeTrailHeadsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Trailhead Trailhead { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Trailhead.Add(Trailhead);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
