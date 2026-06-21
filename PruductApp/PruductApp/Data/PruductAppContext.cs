using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruductApp.Models;

namespace PruductApp.Data
{
    public class PruductAppContext : DbContext
    {
        public PruductAppContext (DbContextOptions<PruductAppContext> options)
            : base(options)
        {
        }

        public DbSet<PruductApp.Models.Product> Product { get; set; } = default!;
    }
}
