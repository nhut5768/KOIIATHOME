using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using koi.respositories.Entities;

namespace koi.webapp.Pages.FishManagement
{
    public class EditModel : PageModel
    {
        private readonly koi.respositories.Entities.KoiFishManagementDbContext _context;

        public EditModel(koi.respositories.Entities.KoiFishManagementDbContext context)
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

            var fish =  await _context.Fish.FirstOrDefaultAsync(m => m.Id == id);
            if (fish == null)
            {
                return NotFound();
            }
            Fish = fish;
           ViewData["PondId"] = new SelectList(_context.Ponds, "Id", "Name");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Fish).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FishExists(Fish.Id))
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

        private bool FishExists(int id)
        {
            return _context.Fish.Any(e => e.Id == id);
        }
    }
}
