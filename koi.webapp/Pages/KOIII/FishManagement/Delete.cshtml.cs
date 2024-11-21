using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using koi.respositories.Entities;

namespace koi.webapp.Pages.FishManagement
{
    public class DeleteModel : PageModel
    {
        private readonly koi.respositories.Entities.KoiFishManagementDbContext _context;

        public DeleteModel(koi.respositories.Entities.KoiFishManagementDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Fish Fish { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fish = await _context.Fish.FirstOrDefaultAsync(m => m.Id == id);

            if (fish == null)
            {
                return NotFound();
            }
            else
            {
                Fish = fish;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fish = await _context.Fish.FindAsync(id);
            if (fish != null)
            {
                Fish = fish;
                _context.Fish.Remove(Fish);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
