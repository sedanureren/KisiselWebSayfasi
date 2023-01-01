using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KisiselWebSayfasi.Migrations
{
    /// <inheritdoc />
    public partial class m5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nufus",
                table: "Sehrims");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nufus",
                table: "Sehrims",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
