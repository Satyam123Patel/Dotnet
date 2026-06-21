using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Product_Test.Models;

namespace Product_Test.Data
{
    public class Product_TestContext : DbContext
    {
        public Product_TestContext (DbContextOptions<Product_TestContext> options)
            : base(options)
        {
        }

        public DbSet<Product_Test.Models.Product> Product { get; set; } = default!;
    }
}
