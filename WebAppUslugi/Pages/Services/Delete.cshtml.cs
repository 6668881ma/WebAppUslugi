using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppUslugi.Data;
using WebAppUslugi.Data.identity;

namespace WebAppUslugi.Pages.Services
{
    public class DeleteModel : PageModel
    {
        private readonly WebAppUslugi.Data.ApplicationDbContext _context;

        public DeleteModel(WebAppUslugi.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Service Service { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.services.FirstOrDefaultAsync(m => m.Id == id);

            if (service == null)
            {
                return NotFound();
            }
            else
            {
                Service = service;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.services.FindAsync(id);
            if (service != null)
            {
                Service = service;
                _context.services.Remove(Service);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
