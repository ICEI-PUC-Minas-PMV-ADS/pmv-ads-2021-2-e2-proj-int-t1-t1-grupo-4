using Microsoft.EntityFrameworkCore.Migrations;

namespace app_web_backend.Migrations
{
    public partial class Receita00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receitas",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IngredientePrincipal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TempoPreparo = table.Column<long>(type: "bigint", nullable: false),
                    ModoPreparo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autor = table.Column<int>(type: "int", nullable: false),
                    Imagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContadorFavoritos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receitas", x => x.Codigo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receitas");
        }
    }
}
