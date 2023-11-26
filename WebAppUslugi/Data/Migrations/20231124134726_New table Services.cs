using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppUslugi.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewtableServices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "data");

            migrationBuilder.CreateTable(
                name: "Services",
                schema: "data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "data",
                table: "Services",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 1, "Test", 4m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services",
                schema: "data");
        }
    }
}
