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
    public class DeleteModel : PageModel
    {
        private readonly koi.respositories.Entities.KoiFishManagementDbContext _context;

        public DeleteModel(koi.respositories.Entities.KoiFishManagementDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedcalculation = await _context.FeedCalculations.FindAsync(id);
            if (feedcalculation != null)
            {
                FeedCalculation = feedcalculation;
                _context.FeedCalculations.Remove(FeedCalculation);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
