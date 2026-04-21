using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FUMCFoodPantry.Data
{
    public class FUMCFoodPantryContext : DbContext
    {
        public FUMCFoodPantryContext (DbContextOptions<FUMCFoodPantryContext> options)
            : base(options)
        {
        }

        public DbSet<Stock> Stock { get; set; } = default!;
        public DbSet<User> User { get; set; } = default!;
    }
}
