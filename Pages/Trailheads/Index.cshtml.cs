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
    public class IndexModel : PageModel
    {
        private readonly MountainBikeTrailHeads.Data.MountainBikeTrailHeadsContext _context;

        public IndexModel(MountainBikeTrailHeads.Data.MountainBikeTrailHeadsContext context)
        {
            _context = context;
        }

        public IList<Trailhead> Trailhead { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public string NameSort { get; set; }
        public SelectList Places { get; set; }
        [BindProperty(SupportsGet =true)]
        public string SearchPlace { get; set; }

        //public IList<Trailhead> Trailhead { get;set; }

        public async Task OnGetAsync(string sortOrder)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "NameDesc" : "";

            IQueryable<string> placeQuery = from n in _context.Trailhead
                                            orderby n.CityNear
                                            select n.CityNear;

            var trailheads = from t in _context.Trailhead 
                             select t;

            //search by name
            if (!string.IsNullOrEmpty(SearchString))
            {
                trailheads = trailheads.Where(t => t.Name.Contains(SearchString));
            }

            //search by city near
            if (!string.IsNullOrEmpty(SearchPlace))
            {
                trailheads = trailheads.Where(n => n.CityNear.Contains(SearchPlace));
            }

            //Sort by name
            //if (NameSort == "desc")
            //{
            //    trailheads = trailheads.OrderByDescending(t => t.Name);
            //}
            //else
            //{
            //    trailheads = trailheads.OrderBy(t => t.Name);
            //}
            switch (sortOrder)
            {
                case "NameDesc":
                    trailheads = trailheads.OrderByDescending(t => t.Name);
                    break;
                default:
                    trailheads = trailheads.OrderBy(t => t.Name);
                    break;
            }

            Places = new SelectList(await placeQuery.Distinct().ToListAsync());
            Trailhead = await trailheads.ToListAsync();
        }
    }
}
