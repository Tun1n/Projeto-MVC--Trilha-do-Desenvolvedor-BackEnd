using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias (CategoriaName, Descricao) " +
                "VALUES ('Whisky', 'Bebidas alcoólicas destiladas, feitas a partir da fermentação de grãos como cevada, milho, centeio ou trigo, e envelhecidas em barris de madeira')");

            migrationBuilder.Sql("INSERT INTO Categorias (CategoriaName, Descricao) " +
                "VALUES ('Vinho', 'Bebidas alcoólicas obtidas pela fermentação do suco de uvas, apreciadas por seus diferentes aromas, sabores e estilos, que variam conforme a uva e o processo de produção')");

            migrationBuilder.Sql("INSERT INTO Categorias (CategoriaName, Descricao) " +
                "VALUES ('Destilado', 'Bebidas alcoólicas produzidas pela destilação de líquidos fermentados, resultando em maior teor alcoólico e sabores concentrados')");

            migrationBuilder.Sql("INSERT INTO Categorias (CategoriaName, Descricao) " +
               "VALUES ('Licor', 'Licor é uma bebida alcoólica adocicada, feita a partir da destilação ou maceração de frutas, ervas ou especiarias, geralmente com teor alcoólico mais baixo que destilados puros')");




        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias')");
        }
    }
}