using Microsoft.EntityFrameworkCore.Migrations;

namespace ThePub.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MealTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Appetizer" },
                    { 2, "Main" },
                    { 3, "Dessert" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ordinary" },
                    { 2, "KnowsTheRightPeople" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "MealTypeId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Simple Tomato Soup" },
                    { 30, 3, "Chocolate Chip Cookies" },
                    { 29, 3, "Iced Pumpkin Cookies" },
                    { 28, 3, "Peanut Butter Cup Cookies" },
                    { 27, 3, "Waffles" },
                    { 26, 3, "Carrot Cake" },
                    { 25, 3, "Brownies" },
                    { 24, 3, "Apple Pie" },
                    { 23, 3, "Banana Muffins" },
                    { 22, 3, "Blueberry Muffins" },
                    { 21, 3, "Fluffy Pancakes" },
                    { 20, 2, "Chicken Parmesan" },
                    { 19, 2, "Yummy Sweet Potato Casserole" },
                    { 18, 2, "Steak" },
                    { 17, 2, "Buffalo Chicken Dip" },
                    { 16, 2, "Slow Cooker Beef Stew" },
                    { 15, 2, "Grilled Salmon" },
                    { 14, 2, "Maple Salmon" },
                    { 13, 2, "Chicken Marsala" },
                    { 12, 2, "Garlic Chicken" },
                    { 11, 2, "Baked Teriyaki Chicken" },
                    { 10, 1, "Mexican Soup" },
                    { 9, 1, "Chicken Noodle Soup" },
                    { 8, 1, "Chicken Tortilla Soup" },
                    { 7, 1, "Delicious Ham and Potato Soup" },
                    { 6, 1, "Italian Sausage Soup with Tortellini" },
                    { 5, 1, "Taco Soup" },
                    { 4, 1, "Roasted Brussels Sprouts" },
                    { 3, 1, "Spinach Salad" },
                    { 2, 1, "Potato Soup" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "PasswordHash", "RoleId", "UserName" },
                values: new object[,]
                {
                    { 1, "Gosho", "Goshev", "H9bsSF1//blxVveY2Vc0VgKLiyDIsfLaKsHU1T6ymgw=", 1, "gosho_goshev" },
                    { 2, "Pesho", "Peshov", "cKLnB3Nc47pfA8o7esDe5OBD8jei3u3pvaBhXJICg9o=", 2, "pesho_peshov" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MealTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MealTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MealTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
