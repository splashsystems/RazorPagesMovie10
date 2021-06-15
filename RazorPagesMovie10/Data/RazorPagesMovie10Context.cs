using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie10.Models;

namespace RazorPagesMovie10.Data
{
    public class RazorPagesMovie10Context : DbContext
    {
        public RazorPagesMovie10Context (DbContextOptions<RazorPagesMovie10Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie10.Models.Movie> Movie { get; set; }
    }
}
