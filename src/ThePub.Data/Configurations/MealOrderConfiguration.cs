using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ThePub.Data.Models;

namespace ThePub.Data.Configurations
{
    public class MealOrderConfiguration : IEntityTypeConfiguration<MealOrders>
    {
        public void Configure(EntityTypeBuilder<MealOrders> builder)
        {
            builder.HasKey(x => new { x.OrderId, x.MealId });

            builder.HasOne(x => x.Meal)
                .WithMany(x => x.MealOrders)
                .HasForeignKey(x => x.MealId);

            builder.HasOne(x => x.Order)
                .WithMany(x => x.MealOrders)
                .HasForeignKey(x => x.OrderId);
        }
    }
}
