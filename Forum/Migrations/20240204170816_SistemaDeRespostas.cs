using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forum.Migrations
{
    /// <inheritdoc />
    public partial class SistemaDeRespostas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Respostas_PostagemId",
                table: "Respostas",
                column: "PostagemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Respostas_Postagens_PostagemId",
                table: "Respostas",
                column: "PostagemId",
                principalTable: "Postagens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Respostas_Postagens_PostagemId",
                table: "Respostas");

            migrationBuilder.DropIndex(
                name: "IX_Respostas_PostagemId",
                table: "Respostas");
        }
    }
}
