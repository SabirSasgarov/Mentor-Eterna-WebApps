using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EternaWebbApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "Icon", "Title" },
                values: new object[,]
                {
                    { 1, "Custom web applications built with modern, scalable technologies.", "bi bi-activity", "Web Development" },
                    { 2, "Result-driven strategies to increase your online visibility and growth.", "bi bi-broadcast", "Digital Marketing" },
                    { 3, "Intuitive and engaging user experiences designed for your audience.", "bi bi-easel", "UI/UX Design" },
                    { 4, "Strong and consistent branding to make your business stand out.", "bi bi-bounding-box-circles", "Brand Identity" },
                    { 5, "Structured planning and execution to keep projects on time and budget.", "bi bi-calendar4-week", "Project Planning" },
                    { 6, "Expert advice to help you choose the right technical direction.", "bi bi-chat-square-text", "Consulting" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
