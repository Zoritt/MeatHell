using Microsoft.EntityFrameworkCore.Migrations;

namespace MH.Data.Migrations
{
    public partial class IngredientType_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert IngredientType (Name) values('Wegańskie')");
            migrationBuilder.Sql("insert IngredientType (Name) values('Wegetariańskie')");
            migrationBuilder.Sql("insert IngredientType (Name) values('Klasyczne')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
