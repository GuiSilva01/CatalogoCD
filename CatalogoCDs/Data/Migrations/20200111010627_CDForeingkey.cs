using Microsoft.EntityFrameworkCore.Migrations;

namespace CatalogoCDs.Data.Migrations
{
    public partial class CDForeingkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CD_FaixadePreco_FaixadePrecoId",
                table: "CD");

            migrationBuilder.DropForeignKey(
                name: "FK_CD_Gravadora_GravadoraId",
                table: "CD");

            migrationBuilder.DropForeignKey(
                name: "FK_CD_Musica_MusicaId",
                table: "CD");

            migrationBuilder.AlterColumn<int>(
                name: "MusicaId",
                table: "CD",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GravadoraId",
                table: "CD",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FaixadePrecoId",
                table: "CD",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CD_FaixadePreco_FaixadePrecoId",
                table: "CD",
                column: "FaixadePrecoId",
                principalTable: "FaixadePreco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CD_Gravadora_GravadoraId",
                table: "CD",
                column: "GravadoraId",
                principalTable: "Gravadora",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CD_Musica_MusicaId",
                table: "CD",
                column: "MusicaId",
                principalTable: "Musica",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CD_FaixadePreco_FaixadePrecoId",
                table: "CD");

            migrationBuilder.DropForeignKey(
                name: "FK_CD_Gravadora_GravadoraId",
                table: "CD");

            migrationBuilder.DropForeignKey(
                name: "FK_CD_Musica_MusicaId",
                table: "CD");

            migrationBuilder.AlterColumn<int>(
                name: "MusicaId",
                table: "CD",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "GravadoraId",
                table: "CD",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "FaixadePrecoId",
                table: "CD",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_CD_FaixadePreco_FaixadePrecoId",
                table: "CD",
                column: "FaixadePrecoId",
                principalTable: "FaixadePreco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CD_Gravadora_GravadoraId",
                table: "CD",
                column: "GravadoraId",
                principalTable: "Gravadora",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CD_Musica_MusicaId",
                table: "CD",
                column: "MusicaId",
                principalTable: "Musica",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
