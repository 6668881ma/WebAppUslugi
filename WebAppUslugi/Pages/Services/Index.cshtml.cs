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
    public class IndexModel : PageModel
    {
        private readonly WebAppUslugi.Data.ApplicationDbContext _context;

        public IndexModel(WebAppUslugi.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Service> Service { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Service = await _context.services.ToListAsync();
        }
    }
}
