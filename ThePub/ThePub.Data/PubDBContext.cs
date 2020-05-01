using Microsoft.EntityFrameworkCore;
using ThePub.Data.Configurations;
using ThePub.Data.Models;

namespace ThePub.Data
{
    public class PubDBContext : DbContext
    {
        public PubDBContext(DbContextOptions<PubDBContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Meal> Meals { get; set; }

        public DbSet<MealType> MealTypes { get; set; }

        public DbSet<MealOrders> MealOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new MealOrderConfiguration());
            modelBuilder.ApplyConfiguration(new MealSeedConfiguration());
            modelBuilder.ApplyConfiguration(new MealTypesSeedConfiguration());
            modelBuilder.ApplyConfiguration(new RoleSeedConfiguration());
            modelBuilder.ApplyConfiguration(new UserSeedConfiguration());
        }
    }
}
