﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using koi.respositories.Entities;

namespace koi.webapp.Pages.PondManagement
{
    public class CreateModel : PageModel
    {
        private readonly koi.respositories.Entities.KoiFishManagementDbContext _context;

        public CreateModel(koi.respositories.Entities.KoiFishManagementDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Pond Pond { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Ponds.Add(Pond);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
