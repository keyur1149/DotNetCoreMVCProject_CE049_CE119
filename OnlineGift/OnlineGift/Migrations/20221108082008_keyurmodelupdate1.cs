using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineGift.Migrations
{
    public partial class keyurmodelupdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "desc",
                table: "keyurs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "prize",
                table: "keyurs",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "desc",
                table: "keyurs");

            migrationBuilder.DropColumn(
                name: "prize",
                table: "keyurs");
        }
    }
}
