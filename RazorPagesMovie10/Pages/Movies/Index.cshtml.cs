using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie10.Data;
using RazorPagesMovie10.Models;

namespace RazorPagesMovie10.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie10.Data.RazorPagesMovie10Context _context;

        public IndexModel(RazorPagesMovie10.Data.RazorPagesMovie10Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
