using Microsoft.EntityFrameworkCore.Migrations;

namespace MH.Data.Migrations
{
    public partial class testowamigracjausuniecie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "Notifys");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "Notifys",
                nullable: true);
        }
    }
}
