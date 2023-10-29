using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Timonea_Razvan_Lab2_.Data;
using Timonea_Razvan_Lab2_.Models;

namespace Timonea_Razvan_Lab2_.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Timonea_Razvan_Lab2_.Data.Timonea_Razvan_Lab2_Context _context;

        public IndexModel(Timonea_Razvan_Lab2_.Data.Timonea_Razvan_Lab2_Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }
        }
    }
}
