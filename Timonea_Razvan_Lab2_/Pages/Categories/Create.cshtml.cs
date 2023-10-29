using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Timonea_Razvan_Lab2_.Data;
using Timonea_Razvan_Lab2_.Models;

namespace Timonea_Razvan_Lab2_.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Timonea_Razvan_Lab2_.Data.Timonea_Razvan_Lab2_Context _context;

        public CreateModel(Timonea_Razvan_Lab2_.Data.Timonea_Razvan_Lab2_Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Category == null || Category == null)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
