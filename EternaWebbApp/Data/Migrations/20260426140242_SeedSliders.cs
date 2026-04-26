using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EternaWebbApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedSliders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "ButtonLink", "ButtonText", "ImageUrl", "Name", "SubTitle" },
                values: new object[,]
                {
                    { 1, "#", "Read More", "hero-carousel-1.jpg", "Welcome to Eterna", "Modern and clean design" },
                    { 2, "#", "Get Started", "hero-carousel-2.jpg", "Build Better Websites", "Fast, responsive and elegant" },
                    { 3, "#", "Learn More", "hero-carousel-3.jpg", "Grow Your Business", "Solutions for your success" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
