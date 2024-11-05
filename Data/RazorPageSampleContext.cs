using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPageSample.Models;

namespace RazorPageSample.Data
{
    public class RazorPageSampleContext : DbContext
    {
        public RazorPageSampleContext (DbContextOptions<RazorPageSampleContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPageSample.Models.Movie> Movie { get; set; } = default!;
    }
}
