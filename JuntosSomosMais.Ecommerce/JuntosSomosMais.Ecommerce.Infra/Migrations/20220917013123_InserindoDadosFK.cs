using Microsoft.EntityFrameworkCore.Migrations;

namespace JuntosSomosMais.Ecommerce.Infra.Migrations
{
    public partial class InserindoDadosFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO ENDERECO VALUES('ALDEBIADES', 'RIBEIRA', '54', '40420-021', '1 ANDAR', 'AO LADO DA PREFEITURA', 'SALVADOR', 'BA', 'BRASIL', 1); ");
            migrationBuilder.Sql("INSERT INTO ENDERECO VALUES('JORGE LEAO','MASSARANDUBA','99','13221-000','TERREO','PERTO DA PADARIA','FEIRA DE SANTANA','BA','BRASIL',2); ");
            migrationBuilder.Sql("INSERT INTO ENDERECO VALUES('AGUAS CRISTALINAS', 'PITUBA', '33', '44433-022', 'ULTIMO ANDAR', 'AZULEJO ROSA', 'RIO DE JANEIRO', 'RJ', 'BRASIL', 3); ");

            migrationBuilder.Sql("INSERT INTO PEDIDO VALUES('2022-09-01',1);");
            migrationBuilder.Sql("INSERT INTO PEDIDO VALUES('2022-09-01',1);");
            migrationBuilder.Sql("INSERT INTO PEDIDO VALUES('2022-09-01',1);");

            migrationBuilder.Sql("INSERT INTO PEDIDO_PRODUTO VALUES(1,1,5);");
            migrationBuilder.Sql("INSERT INTO PEDIDO_PRODUTO VALUES(1,2,10);");
            migrationBuilder.Sql("INSERT INTO PEDIDO_PRODUTO VALUES(1,3,15);");
            migrationBuilder.Sql("INSERT INTO PEDIDO_PRODUTO VALUES(2,1,11);");
            migrationBuilder.Sql("INSERT INTO PEDIDO_PRODUTO VALUES(2,5,4);");
            migrationBuilder.Sql("INSERT INTO PEDIDO_PRODUTO VALUES(2,3,8);");
            migrationBuilder.Sql("INSERT INTO PEDIDO_PRODUTO VALUES(3,4,7);");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
