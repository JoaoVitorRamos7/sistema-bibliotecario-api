using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistema_bibliotecario_api.Migrations
{
    /// <inheritdoc />
    public partial class AddUsuarioEmprestimo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Ativo = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Emprestimos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Usuario_id = table.Column<int>(type: "int", nullable: false),
                    usuarioId = table.Column<int>(type: "int", nullable: true),
                    Livro_id = table.Column<int>(type: "int", nullable: false),
                    DataEmprestimo = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataDevolucaoPresvista = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataDevolucaoReal = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Devolvido = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprestimos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emprestimos_Livros_Livro_id",
                        column: x => x.Livro_id,
                        principalTable: "Livros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Emprestimos_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimos_Livro_id",
                table: "Emprestimos",
                column: "Livro_id");

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimos_usuarioId",
                table: "Emprestimos",
                column: "usuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emprestimos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
