using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientesApp.Migrations
{
    public partial class RenomearColunasParaSnakeCase_fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clientes",
                newName: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Clientes",
                newName: "Id");
        }
    }
}
