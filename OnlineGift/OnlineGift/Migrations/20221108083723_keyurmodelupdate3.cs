using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineGift.Migrations
{
    public partial class keyurmodelupdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.RenameColumn(
                name: "prize",
                table: "keyurs",
                newName: "Prize");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "keyurs",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "desc",
                table: "keyurs",
                newName: "Desc");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Prize",
                table: "keyurs",
                newName: "prize");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "keyurs",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "keyurs",
                newName: "desc");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }
    }
}
