using Microsoft.EntityFrameworkCore.Migrations;

namespace MH.Data.Migrations
{
    public partial class NotifysSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Notifys values('Komunikat 1', GETDATE()), ('Komunikat 2', GETDATE())");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
