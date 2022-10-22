using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharicApi.Migrations
{
    public partial class AddLoginForDriverEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Drivers",
                newName: "Login");

            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PasswordId",
                table: "Drivers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Password",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Value = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Password", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_PasswordId",
                table: "Drivers",
                column: "PasswordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_Password_PasswordId",
                table: "Drivers",
                column: "PasswordId",
                principalTable: "Password",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_Password_PasswordId",
                table: "Drivers");

            migrationBuilder.DropTable(
                name: "Password");

            migrationBuilder.DropIndex(
                name: "IX_Drivers_PasswordId",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "PasswordId",
                table: "Drivers");

            migrationBuilder.RenameColumn(
                name: "Login",
                table: "Drivers",
                newName: "Password");

            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "Users",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
