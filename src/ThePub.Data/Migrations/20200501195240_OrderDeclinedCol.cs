using Microsoft.EntityFrameworkCore.Migrations;

namespace ThePub.Data.Migrations
{
    public partial class OrderDeclinedCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeclined",
                table: "MealOrders");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeclined",
                table: "Orders",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "BGqVOo9FQYYO6b0+2lvjD1nXaXi0+dn2bpr407rvTjQ=");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "DkzW+hYVSBTBAVbI1crRTfotIV2AoV8lIZqxgzL1F8c=");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeclined",
                table: "Orders");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeclined",
                table: "MealOrders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "H9bsSF1//blxVveY2Vc0VgKLiyDIsfLaKsHU1T6ymgw=");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "cKLnB3Nc47pfA8o7esDe5OBD8jei3u3pvaBhXJICg9o=");
        }
    }
}
