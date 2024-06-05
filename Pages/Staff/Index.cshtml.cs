using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyStore_Web.Models;

namespace MyStore_Web.Pages.Staff
{
    public class IndexModel : PageModel
    {
        private readonly MyStore_Web.Models.MyStoreContext _context;

        public IndexModel(MyStore_Web.Models.MyStoreContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Staffs != null)
            {
                Staff = await _context.Staffs.ToListAsync();
            }
        }
    }
}
