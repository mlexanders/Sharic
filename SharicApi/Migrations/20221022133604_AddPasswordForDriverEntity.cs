using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharicApi.Migrations
{
    public partial class AddPasswordForDriverEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Drivers",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Drivers");
        }
    }
}
