using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineGift.Migrations
{
    public partial class keyurmodelupdate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_keyurs",
                table: "keyurs");

            migrationBuilder.RenameTable(
                name: "keyurs",
                newName: "Keyurs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Keyurs",
                table: "Keyurs",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Keyurs",
                table: "Keyurs");

            migrationBuilder.RenameTable(
                name: "Keyurs",
                newName: "keyurs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_keyurs",
                table: "keyurs",
                column: "Id");
        }
    }
}
