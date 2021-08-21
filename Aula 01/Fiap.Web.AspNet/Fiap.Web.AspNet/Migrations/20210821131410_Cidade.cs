using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiap.Web.AspNet.Migrations
{
    public partial class Cidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeRepresentante",
                table: "Representantes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    CidadeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuantidadeHabitantes = table.Column<int>(type: "int", nullable: false),
                    NomeCidade = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.CidadeId);
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "CidadeId", "Estado", "NomeCidade", "QuantidadeHabitantes" },
                values: new object[] { 1, "SP", "São Paulo", 11 });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "CidadeId", "Estado", "NomeCidade", "QuantidadeHabitantes" },
                values: new object[] { 2, "RJ", "Rio de Janeiro", 5 });

            migrationBuilder.CreateIndex(
                name: "IX_Cidades_NomeCidade_Estado",
                table: "Cidades",
                columns: new[] { "NomeCidade", "Estado" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cidades");

            migrationBuilder.AlterColumn<string>(
                name: "NomeRepresentante",
                table: "Representantes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
