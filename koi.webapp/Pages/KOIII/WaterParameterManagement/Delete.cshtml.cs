﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using koi.respositories.Entities;

namespace koi.webapp.Pages.WaterParameterManagement
{
    public class DeleteModel : PageModel
    {
        private readonly koi.respositories.Entities.KoiFishManagementDbContext _context;

        public DeleteModel(koi.respositories.Entities.KoiFishManagementDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public WaterParameter WaterParameter { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var waterparameter = await _context.WaterParameters.FirstOrDefaultAsync(m => m.Id == id);

            if (waterparameter == null)
            {
                return NotFound();
            }
            else
            {
                WaterParameter = waterparameter;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var waterparameter = await _context.WaterParameters.FindAsync(id);
            if (waterparameter != null)
            {
                WaterParameter = waterparameter;
                _context.WaterParameters.Remove(WaterParameter);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
