using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AgregaUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Multas_Usuarios_UsuarioId",
                table: "Multas");

            migrationBuilder.DropIndex(
                name: "IX_Multas_UsuarioId",
                table: "Multas");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Multas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Multas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Multas_UsuarioId",
                table: "Multas",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Multas_Usuarios_UsuarioId",
                table: "Multas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }
    }
}
