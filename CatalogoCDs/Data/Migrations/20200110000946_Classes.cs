using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CatalogoCDs.Data.Migrations
{
    public partial class Classes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FaixadePreco",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeFaixa = table.Column<string>(nullable: true),
                    PrecoInicial = table.Column<double>(nullable: false),
                    PrecoFinal = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaixadePreco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gravadora",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeGravadora = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gravadora", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Musica",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Faixa = table.Column<string>(nullable: true),
                    Artista = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CD",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeCD = table.Column<string>(nullable: true),
                    DtLancamento = table.Column<DateTime>(nullable: false),
                    GravadoraId = table.Column<int>(nullable: true),
                    FaixadePrecoId = table.Column<int>(nullable: true),
                    MusicaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CD_FaixadePreco_FaixadePrecoId",
                        column: x => x.FaixadePrecoId,
                        principalTable: "FaixadePreco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CD_Gravadora_GravadoraId",
                        column: x => x.GravadoraId,
                        principalTable: "Gravadora",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CD_Musica_MusicaId",
                        column: x => x.MusicaId,
                        principalTable: "Musica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CD_FaixadePrecoId",
                table: "CD",
                column: "FaixadePrecoId");

            migrationBuilder.CreateIndex(
                name: "IX_CD_GravadoraId",
                table: "CD",
                column: "GravadoraId");

            migrationBuilder.CreateIndex(
                name: "IX_CD_MusicaId",
                table: "CD",
                column: "MusicaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CD");

            migrationBuilder.DropTable(
                name: "FaixadePreco");

            migrationBuilder.DropTable(
                name: "Gravadora");

            migrationBuilder.DropTable(
                name: "Musica");
        }
    }
}
