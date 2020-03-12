using Microsoft.EntityFrameworkCore.Migrations;

namespace EsteticaPage.Migrations
{
    public partial class esteticaV11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemServicos_Procedimentos_ProcedimentoId",
                table: "ItemServicos");

            migrationBuilder.AlterColumn<int>(
                name: "ProcedimentoId",
                table: "ItemServicos",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemServicos_Procedimentos_ProcedimentoId",
                table: "ItemServicos",
                column: "ProcedimentoId",
                principalTable: "Procedimentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemServicos_Procedimentos_ProcedimentoId",
                table: "ItemServicos");

            migrationBuilder.AlterColumn<int>(
                name: "ProcedimentoId",
                table: "ItemServicos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ItemServicos_Procedimentos_ProcedimentoId",
                table: "ItemServicos",
                column: "ProcedimentoId",
                principalTable: "Procedimentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
