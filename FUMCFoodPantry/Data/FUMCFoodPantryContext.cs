using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FUMCFoodPantry.Models.Enums;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(u => u.Role).HasConversion<string>();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<UserApplications> UserApplications { get; set; } = default!;
        //I added this section to convert the enums from integers to strings - Jeffrey
    }
}
