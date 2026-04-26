using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EternaWebbApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UsersSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FullName", "ImageUrl", "Position" },
                values: new object[,]
                {
                    { 4, "Amanda Jepson", "testimonials-4.jpg", "Lead Designer" },
                    { 5, "Saul Goodman", "testimonials-5.jpg", "Legal Advisor" },
                    { 6, "Jenna Karlis", "testimonials-6.jpg", "Store Owner" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "StarCount", "UserId" },
                values: new object[,]
                {
                    { 4, "Creative team with strong attention to detail.", 4.5m, 4 },
                    { 5, "Professional, reliable, and easy to work with.", 5m, 5 },
                    { 6, "Very satisfied with the final result and support.", 4m, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
