using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientesApp.Migrations
{
    public partial class RenomearColunasParaSnakeCase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Clientes",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Ativo",
                table: "Clientes",
                newName: "ativo");

            migrationBuilder.RenameColumn(
                name: "DataNascimento",
                table: "Clientes",
                newName: "data_nascimento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Clientes",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "ativo",
                table: "Clientes",
                newName: "Ativo");

            migrationBuilder.RenameColumn(
                name: "data_nascimento",
                table: "Clientes",
                newName: "DataNascimento");
        }
    }
}
