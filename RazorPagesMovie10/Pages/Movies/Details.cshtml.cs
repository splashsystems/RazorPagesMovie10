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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovie10.Data.RazorPagesMovie10Context _context;

        public DetailsModel(RazorPagesMovie10.Data.RazorPagesMovie10Context context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
