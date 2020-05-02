using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ThePub.Data.Models;
using static ThePub.Data.Constants;

namespace ThePub.Data.Configurations
{
    public class MealTypesSeedConfiguration : IEntityTypeConfiguration<MealType>
    {
        public void Configure(EntityTypeBuilder<MealType> builder)
        {
            builder.HasData(
                new MealType { Id = AppetizerMealTypeId, Name = "Appetizer" },
                new MealType { Id = MainMealTypeId, Name = "Main" },
                new MealType { Id = DessertMealTypeId, Name = "Dessert" });
        }
    }
}
