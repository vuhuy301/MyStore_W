using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyStore_Web.Models;

namespace MyStore_Web.Pages.Staff
{
    public class CreateModel : PageModel
    {
        private readonly MyStore_Web.Models.MyStoreContext _context;

        public CreateModel(MyStore_Web.Models.MyStoreContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Staff Staff { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Staffs == null || Staff == null)
            {
                return Page();
            }

            _context.Staffs.Add(Staff);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
