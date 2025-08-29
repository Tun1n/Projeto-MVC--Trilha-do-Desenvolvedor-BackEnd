using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class PopularBebidas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Categoria Whisky = 1
            migrationBuilder.Sql("INSERT INTO Bebidas (Name, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsBebidaPreferida, EmEstoque, CategoriaId) " +
                "VALUES ('Jack Daniel Tradicional 1L','Jack Daniel’s Old No. 7 é um clássico whisky Tennessee, de sabor suave e levemente adocicado, com notas de caramelo, baunilha e toques amadeirados','A Jack Daniel’s tradicional é feita a partir de milho, centeio e cevada maltada, água pura da nascente da Caverna (em Lynchburg, Tennessee) e leveduras próprias da destilaria. Depois da destilação, ela passa pela filtragem em carvão vegetal de bordo-açucarado e é envelhecida em barris novos de carvalho americano carbonizados',140.00,'/images/Jackdaniels.png','/images/Jackdaniels.png',1,1,1)");

            migrationBuilder.Sql("INSERT INTO Bebidas (Name, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsBebidaPreferida, EmEstoque, CategoriaId) " +
                "VALUES ('Johnnie Walker Black Label 1L','Johnnie Walker Black Label é um blended Scotch whisky envelhecido por no mínimo 12 anos, com sabor equilibrado, notas de malte, defumado suave, frutas secas e baunilha','O Johnnie Walker Black Label é feito a partir de cevada maltada, milho e trigo, fermentados e destilados em alambiques de cobre (malte) e contínuos (grão). Os destilados envelhecem por no mínimo 12 anos em barris de carvalho que antes contiveram bourbon ou xerez. Depois, mais de 30 whiskies diferentes são cuidadosamente combinados pelo master blender para criar o sabor equilibrado, frutado e levemente defumado característico do rótulo',160.00,'/images/blacklabel.png','/images/blacklabel.png',0,1,1)");

            migrationBuilder.Sql("INSERT INTO Bebidas (Name, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsBebidaPreferida, EmEstoque, CategoriaId) " +
                "VALUES ('White Horse 1L','White Horse é um blended Scotch whisky escocês de sabor marcante, com notas de malte, carvalho e leve defumado','O White Horse é feito da mistura de whiskies de malte (principalmente cevada maltada, com destaque para o Lagavulin) e whiskies de grão (trigo e milho), todos envelhecidos em barris de carvalho, resultando em um blend encorpado e levemente defumado',85.00,'/images/Whitehorse.png','/images/Whitehorse.png',1,1,1)");

            // Categoria Vinho = 2
            migrationBuilder.Sql("INSERT INTO Bebidas (Name, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsBebidaPreferida, EmEstoque, CategoriaId) " +
                "VALUES('Pergola 1L','O Pergola é um vinho de perfil elegante e agradável, geralmente com aromas delicados de frutas vermelhas e notas florais sutis. No paladar, apresenta sabor frutado, corpo leve a médio e final suave, tornando-o fácil de harmonizar com diferentes pratos e ocasiões','O vinho Pergola é um rótulo que busca equilíbrio entre frutado, frescor e suavidade, tornando-se uma opção versátil para diversas ocasiões. Produzido a partir de uvas selecionadas, ele apresenta aromas delicados de frutas vermelhas maduras, como morango e cereja, muitas vezes complementados por nuances florais e toques sutis de especiarias ou baunilha, dependendo do estilo do vinho',30.00,'/images/Pergola.png','/images/Pergola.png',1,1,2)");

            migrationBuilder.Sql("INSERT INTO Bebidas (Name, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsBebidaPreferida, EmEstoque, CategoriaId) " +
                "VALUES('Concha y Toro Casillero Del Diablo Cabernet Sauvignon 750ml','Vinho tinto seco encorpado, com notas de frutas vermelhas maduras e toque de especiarias','O Concha y Toro Casillero Del Diablo Cabernet Sauvignon 750ml é um vinho tinto chileno de corpo médio a encorpado, reconhecido por seu sabor intenso e equilibrado. Produzido a partir de uvas Cabernet Sauvignon selecionadas, apresenta aromas marcantes de frutas vermelhas maduras, como cereja e framboesa, combinados com sutis notas de especiarias e leve toque de carvalho',51.00,'/images/Casillero.png','/images/Casillero.png',0,1,2)");

            migrationBuilder.Sql("INSERT INTO Bebidas (Name, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsBebidaPreferida, EmEstoque, CategoriaId) " +
                "VALUES('Del Rei Tinto Velha Madeira 1L','Vinho tinto encorpado, com sabor frutado, notas de especiarias e final suave','O Vinho Del Rei Tinto Velha Madeira 1L é um vinho de tradição portuguesa, caracterizado por seu corpo médio a encorpado e perfil aromático rico. Produzido a partir de uvas selecionadas da região da Madeira, apresenta aromas de frutas vermelhas maduras, como ameixa e cereja, combinados com sutis notas de especiarias, carvalho e toques de baunilha devido ao envelhecimento em barris',30.00,'/images/DelRei.png','/images/DelRei.png',1,1,2)");

            // Categoria Destilado = 3
            migrationBuilder.Sql("INSERT INTO Bebidas (Name, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsBebidaPreferida, EmEstoque, CategoriaId) " +
                "VALUES('Askov Tradicional 900ml','Cachaça suave e clássica, com sabor equilibrado e leve toque de madeira.','A Askov Tradicional é uma cachaça brasileira de alta qualidade, produzida a partir da fermentação e destilação do caldo de cana-de-açúcar puro. Ela passa por um processo de envelhecimento em barris de madeira, que confere ao destilado notas sutis de caramelo, baunilha e um leve toque amadeirado, mantendo a suavidade característica de uma cachaça bem equilibrada',36.00,'/images/Askov.png','/images/Askov.png',0,1,3)");

            migrationBuilder.Sql("INSERT INTO Bebidas (Name, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsBebidaPreferida, EmEstoque, CategoriaId) " +
                "VALUES('Seagers Gin 980ml','Seagers Gin: Gin suave e refrescante, com notas cítricas e botânicas clássicas','O Seagers Gin é um gin clássico, produzido a partir de uma base neutra de destilado e cuidadosamente aromatizado com botânicos selecionados, incluindo zimbro, coentro, casca de cítricos e outras especiarias que conferem complexidade e frescor à bebida',53.00,'/images/Seagers.png','/images/Seagers.png',1,1,3)");

            migrationBuilder.Sql("INSERT INTO Bebidas (Name, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsBebidaPreferida, EmEstoque, CategoriaId) " +
                "VALUES('José Cuervo 750ml','Tequila mexicana clássica, com sabor suave, notas de agave e leve toque amadeirado','A Tequila José Cuervo é uma das mais tradicionais tequilas mexicanas, produzida a partir da agave azul (Agave tequilana) cultivada nas terras do estado de Jalisco, México. A produção segue métodos tradicionais, incluindo cozimento da agave, extração do suco, fermentação natural e destilação cuidadosa, garantindo pureza e qualidade',150.00,'/images/Josecuervo.png','/images/Josecuervo.png',1,1,3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Bebidas");
        }
    }
}
