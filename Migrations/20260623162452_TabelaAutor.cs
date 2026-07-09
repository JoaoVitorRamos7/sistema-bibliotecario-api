using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistema_blibiotecario_api.Migrations
{
    /// <inheritdoc />
    public partial class TabelaAutor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Autor_id",
                table: "Livros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Livros_Autor_id",
                table: "Livros",
                column: "Autor_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Autores_Autor_id",
                table: "Livros",
                column: "Autor_id",
                principalTable: "Autores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Autores_Autor_id",
                table: "Livros");

            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropIndex(
                name: "IX_Livros_Autor_id",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "Autor_id",
                table: "Livros");
        }
    }
}
