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
    public class IndexModel : PageModel
    {
        private readonly koi.respositories.Entities.KoiFishManagementDbContext _context;

        public IndexModel(koi.respositories.Entities.KoiFishManagementDbContext context)
        {
            _context = context;
        }

        public IList<WaterParameter> WaterParameter { get;set; } = default!;

        public async Task OnGetAsync()
        {
            WaterParameter = await _context.WaterParameters
                .Include(w => w.Pond).ToListAsync();
        }
    }
}
