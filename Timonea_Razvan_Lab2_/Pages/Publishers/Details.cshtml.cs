﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Timonea_Razvan_Lab2_.Data;
using Timonea_Razvan_Lab2_.Models;

namespace Timonea_Razvan_Lab2_.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Timonea_Razvan_Lab2_.Data.Timonea_Razvan_Lab2_Context _context;

        public DetailsModel(Timonea_Razvan_Lab2_.Data.Timonea_Razvan_Lab2_Context context)
        {
            _context = context;
        }

      public Publisher Publisher { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Publisher == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else 
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
