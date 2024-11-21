using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using koi.respositories.Entities;

namespace koi.webapp.Pages.FeedCalculationManagement
{
    public class DetailsModel : PageModel
    {
        private readonly koi.respositories.Entities.KoiFishManagementDbContext _context;

        public DetailsModel(koi.respositories.Entities.KoiFishManagementDbContext context)
        {
            _context = context;
        }

        public FeedCalculation FeedCalculation { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedcalculation = await _context.FeedCalculations.FirstOrDefaultAsync(m => m.Id == id);
            if (feedcalculation == null)
            {
                return NotFound();
            }
            else
            {
                FeedCalculation = feedcalculation;
            }
            return Page();
        }
    }
}
