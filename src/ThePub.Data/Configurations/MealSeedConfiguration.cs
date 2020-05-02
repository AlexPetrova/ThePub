using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ThePub.Data.Models;
using static ThePub.Data.Constants;

namespace ThePub.Data.Configurations
{
    public class MealSeedConfiguration : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            int id = 0;

            builder.HasData(
                new Meal { Id = ++id, Name = "Simple Tomato Soup", MealTypeId = AppetizerMealTypeId },
                new Meal { Id = ++id, Name = "Potato Soup", MealTypeId = AppetizerMealTypeId },
                new Meal { Id = ++id, Name = "Spinach Salad", MealTypeId = AppetizerMealTypeId },
                new Meal { Id = ++id, Name = "Roasted Brussels Sprouts", MealTypeId = AppetizerMealTypeId },
                new Meal { Id = ++id, Name = "Taco Soup", MealTypeId = AppetizerMealTypeId },
                new Meal { Id = ++id, Name = "Italian Sausage Soup with Tortellini", MealTypeId = AppetizerMealTypeId },
                new Meal { Id = ++id, Name = "Delicious Ham and Potato Soup", MealTypeId = AppetizerMealTypeId },
                new Meal { Id = ++id, Name = "Chicken Tortilla Soup", MealTypeId = AppetizerMealTypeId },
                new Meal { Id = ++id, Name = "Chicken Noodle Soup", MealTypeId = AppetizerMealTypeId },
                new Meal { Id = ++id, Name = "Mexican Soup", MealTypeId = AppetizerMealTypeId },

                new Meal { Id = ++id, Name = "Baked Teriyaki Chicken", MealTypeId = MainMealTypeId },
                new Meal { Id = ++id, Name = "Garlic Chicken", MealTypeId = MainMealTypeId },
                new Meal { Id = ++id, Name = "Chicken Marsala", MealTypeId = MainMealTypeId },
                new Meal { Id = ++id, Name = "Maple Salmon", MealTypeId = MainMealTypeId },
                new Meal { Id = ++id, Name = "Grilled Salmon", MealTypeId = MainMealTypeId },
                new Meal { Id = ++id, Name = "Slow Cooker Beef Stew", MealTypeId = MainMealTypeId },
                new Meal { Id = ++id, Name = "Buffalo Chicken Dip", MealTypeId = MainMealTypeId },
                new Meal { Id = ++id, Name = "Steak", MealTypeId = MainMealTypeId },
                new Meal { Id = ++id, Name = "Yummy Sweet Potato Casserole", MealTypeId = MainMealTypeId },
                new Meal { Id = ++id, Name = "Chicken Parmesan", MealTypeId = MainMealTypeId },

                new Meal { Id = ++id, Name = "Fluffy Pancakes", MealTypeId = DessertMealTypeId },
                new Meal { Id = ++id, Name = "Blueberry Muffins", MealTypeId = DessertMealTypeId },
                new Meal { Id = ++id, Name = "Banana Muffins", MealTypeId = DessertMealTypeId },
                new Meal { Id = ++id, Name = "Apple Pie", MealTypeId = DessertMealTypeId },
                new Meal { Id = ++id, Name = "Brownies", MealTypeId = DessertMealTypeId },
                new Meal { Id = ++id, Name = "Carrot Cake", MealTypeId = DessertMealTypeId },
                new Meal { Id = ++id, Name = "Waffles", MealTypeId = DessertMealTypeId },
                new Meal { Id = ++id, Name = "Peanut Butter Cup Cookies", MealTypeId = DessertMealTypeId },
                new Meal { Id = ++id, Name = "Iced Pumpkin Cookies", MealTypeId = DessertMealTypeId },
                new Meal { Id = ++id, Name = "Chocolate Chip Cookies", MealTypeId = DessertMealTypeId }
            );
        }
    }
}
